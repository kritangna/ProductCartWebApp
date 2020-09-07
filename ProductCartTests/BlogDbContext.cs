using Microsoft.EntityFrameworkCore;
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

        public DbSet<DummyProductSchema> ProductCartDummyData { get; set; }
    }
}
