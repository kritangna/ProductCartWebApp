using System;
using System.Collections.Generic;
using System.Text;
using ProductCart.Models;

namespace ProductCartTests
{
    class DummyDataDbInitializer
    {
        public DummyDataDbInitializer()
        {

        }

        public void Seed(BlogDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            //Problem in referencing the Product class from ProductCart.Models
            context.Product.AddRange();
            context.SaveChanges();
            
        }
    }
}
