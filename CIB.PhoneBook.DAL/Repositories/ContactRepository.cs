using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using CIB.PhoneBook.DAL.BaseClasses;
using CIB.PhoneBook.DAL.Model;

namespace CIB.PhoneBook.DAL.Repositories
{
    public class ContactRepository : Repository<Contact>
    {
        public PhoneBookEntities PhoneBookEntities { get; set; }

        public ContactRepository()
        {
            PhoneBookEntities = Context.DbContext as PhoneBookEntities ?? new PhoneBookEntities();
        }

        public ContactRepository(PhoneBookEntities dbContext)
        {
            PhoneBookEntities = dbContext;
        }
        
    }
}
