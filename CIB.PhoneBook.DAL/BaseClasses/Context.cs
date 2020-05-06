using System.Data.Entity;
using CIB.PhoneBook.DAL.Interfaces;
using CIB.PhoneBook.DAL.Model;

namespace CIB.PhoneBook.DAL.BaseClasses
{
    public class Context<T> : IContext<T> where T : class
    {
        public Context()
        {
            DbContext = new PhoneBookEntities();
            DbSet = DbContext.Set<T>();
        }

        public Context(DbContext db)
        {
            DbContext = db;
            DbSet = DbContext.Set<T>();
        }

        public DbContext DbContext { get; set; }

        public IDbSet<T> DbSet { get; set; }

        public void Dispose()
        {
            DbContext.Dispose();
        }
    }
}
