using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;
using System.Data.Entity;
namespace WebApplication2.DAL
{
        public class Init : System.Data.Entity.DropCreateDatabaseIfModelChanges<ProContext>
        {
            protected override void Seed(ProContext context)
            {
                var Products = new List<Product>
                {
                new Product{ProductID=1,ProName="A",Price=500},
                new Product{ProductID=2,ProName="B",Price=700}
                };

                Products.ForEach(s => context.Products.Add(s));
                context.SaveChanges();

                var Orders = new List<Order>
                {
                new Order{ProductID=1},
                new Order{ProductID=2}
                };

                Orders.ForEach(s => context.Orders.Add(s));
                context.SaveChanges();

            }
        }
}