using System;
using System.Data.Entity;

namespace CIB.PhoneBook.DAL.Interfaces
{
    public interface IContext<T> : IDisposable where T : class
    {
        DbContext DbContext { get; set; }
        IDbSet<T> DbSet { get; set; }
    }
}
