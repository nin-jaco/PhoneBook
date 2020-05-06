using System;
using System.Data.Entity;

namespace CIB.PhoneBook.Services.WebApi.Models
{
    public class PhoneBookDbContext : DbContext
    {
        public PhoneBookDbContext()
            : base("name=PhoneBookDbContext")
        {
            Database.CreateIfNotExists();
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>()
                .HasKey(o => new { o.LastName, o.DateCreated, o.DateModified, o.FirstName, o.Mobile, o.WorkTelephone, o.Id });
        }
        

        public virtual DbSet<Contact> Contacts { get; set; }
    }
    
}
