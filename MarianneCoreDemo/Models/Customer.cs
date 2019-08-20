using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarianneCoreDemo.Models
{
    public class Customer
    {
        // properties
        [Key]
        public int CustomerId { get; set; }

        [MaxLength(30)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }

        public DateTime Added { get; set; }

        public decimal CreditLimit { get; set; }
    }
}
