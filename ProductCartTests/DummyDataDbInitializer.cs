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
            context.ProductCartDummyData.AddRange( 
                new Product() { ProdID = 1, ProdName = "ProdOne", ProdImageName = "ProdImageOne", ProdPrice = 345 },
                new Product() { ProdID = 2, ProdName = "ProdTwo", ProdImageName = "ProdImageTwo", ProdPrice = 345.56},
                new Product() { ProdID = 3, ProdName = "ProdThree", ProdImageName = "ProdImageThree", ProdPrice = 123.4}
                );
            context.SaveChanges();
            
        }
    }
}
