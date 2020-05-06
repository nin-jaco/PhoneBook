namespace CIB.PhoneBook.SPA.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CIB.PhoneBook.SPA.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<CIB.PhoneBook.SPA.Models.ContactDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CIB.PhoneBook.SPA.Models.ContactDb context)
        {
            context.Contacts.AddOrUpdate(new Contact[]
            {
                new Contact
                {
                    FirstName = "Bob",
                    LastName = "Skinstad",
                    Mobile = "0741234567",
                    WorkTelephone = "0115551234",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new Contact
                {
                    FirstName = "Sarie",
                    LastName = "Marais",
                    Mobile = "0821234567",
                    WorkTelephone = "0115551234",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new Contact
                {
                    FirstName = "Jacob",
                    LastName = "Mmezie",
                    Mobile = "0831234567",
                    WorkTelephone = "0115551234",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                }
            });

            context.SaveChanges();
        }
    }
}
