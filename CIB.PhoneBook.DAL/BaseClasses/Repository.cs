using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using CIB.PhoneBook.DAL.Extensions;
using CIB.PhoneBook.DAL.Interfaces;

namespace CIB.PhoneBook.DAL.BaseClasses
{
    public class Repository<T> : IRepository<T> , IDisposable where T : class
    {
        public IContext<T> Context { get; protected set; }
        protected DbSet<T> DbSet;
        public DbContextTransaction Transaction { get; set; }

        public Repository()
        {
            Context = new Context<T>();
            Context.DbContext.Database.CommandTimeout = 300;
            DbSet = Context.DbContext.Set<T>();

        }

        public Repository(IContext<T> context)
        {
            Context = context;
        }

        public virtual T Get(object key)
        {
            return DbSet.Find(key);
        }

        public virtual IQueryable<T> GetAll()
        {
            return DbSet;
        }

        public T SearchFirst(Expression<Func<T, bool>> predicate)
        {
            return DbSet.FirstOrDefault(predicate);
        }

        public IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public virtual T Add(T entity)
        {
            Context.DbSet.Add(entity);
            SaveChanges();
            return entity;
        }

        public virtual T Remove(T entity)
        {
            Context.DbSet.Attach(entity);
            Context.DbSet.Remove(entity);
            SaveChanges();
            return entity;
        }

        public virtual T Update(object key, T entity)
        {
            var target = Get(key);
            UpdateIfDifferent(target, entity);
            SaveChanges();
            return entity;
        }

        public virtual void SaveChanges()
        {
            try
            {
                Context.DbContext.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void UpdateIfDifferent(T target, T source)
        {
            PropertyInfo property = null;
            object targetValue = null;
            object sourceValue = null;

            try
            {
                foreach (var prop in target.GetType().GetProperties())
                {
                    property = prop;
                    if (Context.DbContext.Entry(target).Member(prop.Name) is DbReferenceEntry) continue;
                    if (prop.IsNonStringEnumerable()) continue;

                    targetValue = GetPropValue(target, prop.Name);
                    sourceValue = GetPropValue(source, prop.Name);

                    if (targetValue == null && sourceValue == null) continue;

                    if (targetValue == null || !targetValue.Equals(sourceValue))
                    {
                        SetPropertyValue(target, prop.Name, sourceValue);
                        Context.DbContext.Entry(target).Property(prop.Name).IsModified = true;
                    }
                }
            }
            catch (Exception e)
            {
                var errorMessage = e.Message + $@"Exception caught in UpdateIfDifferent, Repository.cs. Property name {property?.Name}, targetValue {targetValue?.ToString()}, sourceValue {sourceValue?.ToString()}";
                throw new Exception(errorMessage, e);
            }
            
        }

        public static object GetPropValue(object src, string propName)
        {
            object result = null;
            try
            {
                return result = src.GetType().GetProperty(propName)?.GetValue(src, null);
            }
            catch (Exception e)
            {
                var errorMessage = e.Message + $@"Exception caught in GetPropValue, In Repository.cs. Property name {propName}, Value is null {result}";
                throw new Exception(errorMessage, e);
            }
        }

        public static void SetPropertyValue(object obj, string propName, object value)
        {
            try
            {
                obj.GetType().GetProperty(propName)?.SetValue(obj, value, null);
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
                throw;
            }
        }


        public void RollBack()
        {
            Transaction.Rollback();
            Dispose();
        }

        public void Dispose()
        {
            Transaction?.Dispose();
            Context?.Dispose();
        }

       
        public virtual void SetValues(int id, T newObject)
        {
            var existingObject = Get(id);
            Context.DbContext.Entry(existingObject).CurrentValues.SetValues(newObject);
            SaveChanges();
        }

        
    }

}