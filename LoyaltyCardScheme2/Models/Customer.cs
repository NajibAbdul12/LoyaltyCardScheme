using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LoyaltyCardScheme2.Models
{
    public class Customer : Address
    {

        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string PostCode { get; set; }
        public long Telephone { get; set; }
        public int Age { get; set; }
    }
}
