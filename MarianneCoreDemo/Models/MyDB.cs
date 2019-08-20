using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarianneCoreDemo.Models
{
    public class MyDB : DbContext      //MyDB inherits from DbContext //using statement
    {
        public DbSet<Product> Products  { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}
