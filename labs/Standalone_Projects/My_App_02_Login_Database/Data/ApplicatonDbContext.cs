using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using My_App_02_Login_Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_App_02_Login_Database.Data
{
    public class ApplicatonDbContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicatonDbContext(DbContextOptions<ApplicatonDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
