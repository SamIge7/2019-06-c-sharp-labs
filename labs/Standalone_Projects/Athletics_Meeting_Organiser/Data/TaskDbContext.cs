using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Athletics_Meeting_Organiser.Data
{
    public class TaskDbContext: DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options)
            : base(options)
        {
        }
    }
}
