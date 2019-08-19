using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace McMovie_Rick_Anderson_Tutorial.Models
{
    public class McMovie_Rick_Anderson_TutorialContext : DbContext
    {
        public McMovie_Rick_Anderson_TutorialContext (DbContextOptions<McMovie_Rick_Anderson_TutorialContext> options)
            : base(options)
        {
        }

        public DbSet<McMovie_Rick_Anderson_Tutorial.Models.Movie> Movie { get; set; }
    }
}
