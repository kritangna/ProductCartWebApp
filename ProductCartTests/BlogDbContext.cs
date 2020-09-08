using Microsoft.EntityFrameworkCore;
using ProductCart.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCartTests
{
    class BlogDbContext:DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options):base(options)
        {

        }

        public DbSet<Product> ProductCartDummyData { get; set; }
    }
}
