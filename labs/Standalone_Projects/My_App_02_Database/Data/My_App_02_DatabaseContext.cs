using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using My_App_02_Database.Models;

namespace My_App_02_Database.Models
{
    public class My_App_02_DatabaseContext : DbContext
    {
        public My_App_02_DatabaseContext (DbContextOptions<My_App_02_DatabaseContext> options)
            : base(options)
        {
        }
        public DbSet<My_App_02_Database.Models.User> User { get; set; }

        
    }
}
