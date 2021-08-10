using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoyaltyCardScheme2.Models;

namespace LoyaltyCardScheme2.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CustomerContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Customers.Any())
            {
                return;   // DB has been seeded
            }

            var customers = new Customer[]
            {
            new Customer{Title="Mr",FirstName="Najib",Surname="Abdulkhadir",Address1="129 Bordesley Green",Address2="Bordesley Green East",Address3="Birmingham",Address4="",PostCode="B9 5SR",Telephone=074564564673, Age=23 },
            new Customer{Title="Mr",FirstName="Mohammed",Surname="Abdul",Address1="12 Kenwood Road",Address2="Kenwood Green Road",Address3="Birmingham",Address4="",PostCode="B8 YHJ",Telephone=07495495465, Age=30 },

            };
            foreach (Customer s in customers)
            {
                context.Customers.Add(s);
            }
            context.SaveChanges();
        }
    }
}
