using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarianneCoreDemo.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [MaxLength(80)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        [MaxLength(8)]
        public string Status { get; set; }
    }
}
