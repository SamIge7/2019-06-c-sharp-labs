using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_App_03.Models
{
    public class DataContext: DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
