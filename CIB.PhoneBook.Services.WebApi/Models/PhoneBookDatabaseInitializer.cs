using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CIB.PhoneBook.Services.WebApi.Models
{

    public class PhoneBookDatabaseInitializer : CreateDatabaseIfNotExists<PhoneBookDbContext>
    {
        protected override void Seed(PhoneBookDbContext context)
        {
            base.Seed(context);

            var contacts = new List<Contact>();

            contacts.Add(new Contact
            {
                FirstName = "Bob",
                LastName = "Skinstad",
                Mobile = "0741234567",
                WorkTelephone = "0115551234",
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
            });

            contacts.Add(new Contact
            {
                FirstName = "Sarie",
                LastName = "Marais",
                Mobile = "0821234567",
                WorkTelephone = "0115551234",
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
            });

            contacts.Add(new Contact
            {
                FirstName = "Jacob",
                LastName = "Mmezie",
                Mobile = "0831234567",
                WorkTelephone = "0115551234",
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now
            });

            context.Contacts.AddRange(contacts);
            context.SaveChanges();
        }

    }
}