using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace My_App_03b.Models
{
    public class DataContext: DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}