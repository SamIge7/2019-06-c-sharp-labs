using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labs_76b_ASP_Core_Website.Models
{
    public class Northwind : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public Northwind() { }

        public Northwind(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Northwind;Integrated Security=true;MultipleActiveResultSets=true;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
