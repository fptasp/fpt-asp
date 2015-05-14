using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication2.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProName { get; set; }
        public long Price { get; set; }
        public virtual ICollection<Link> Links { get; set; }
        public class ProDBContext : DbContext
        {
            public DbSet<Product> Products { get; set; }
        }
    }
}