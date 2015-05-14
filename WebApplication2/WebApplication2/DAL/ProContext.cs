using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebApplication2.DAL
{
        public class ProContext : DbContext
        {

            public ProContext() : base("ProContext")
            {
            }

            public DbSet<Product> Products { get; set; }
            public DbSet<Order> Orders { get; set; }
            public DbSet<Link> Links { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }
        }
}