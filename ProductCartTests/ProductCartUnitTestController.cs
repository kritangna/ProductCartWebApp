using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCartTests
{
    class ProductCartUnitTestController
    {
        //private PostRepository repository;
        public static DbContextOptions<BlogDbContext> dbContextOptions { get;}

        public static string connectionString = "Server=(local)\\sqlexpress; Database=ProductCartDummyDB; Trusted_Connection=True; MultipleActiveResultSets=True";
      
    }
}
