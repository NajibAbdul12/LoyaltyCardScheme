using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LoyaltyCardScheme2.Models
{
    public class Customer 
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string PostCode { get; set; }
        public long Telephone { get; set; }
        public int Age { get; set; }
    }
}
