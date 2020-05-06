using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Microsoft.Extensions.DependencyInjection;

namespace CIB.PhoneBook.Services.WebApi.Models
{
    public static class SampleData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<PhoneBookDbContext>();
            context.Database.Migrate();

            if (!context.Contacts.Any())
            {
                
            }
        }
    }
}

