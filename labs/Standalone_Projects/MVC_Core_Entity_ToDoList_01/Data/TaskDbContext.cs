using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Core_Entity_ToDoList_01.Models;

namespace MVC_Core_Entity_ToDoList_01.Models
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext (DbContextOptions<TaskDbContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Core_Entity_ToDoList_01.Models.Task> Task { get; set; }

        public DbSet<MVC_Core_Entity_ToDoList_01.Models.Category> Category { get; set; }

        //Fluent API Relationships go right here
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Relationships
            //Category Name Required
            builder.Entity<Category>().Property(c => c.CategoryName).IsRequired().HasMaxLength(30);

            //Every Task has one category
            builder.Entity<Category>().HasMany(c => c.Tasks).WithOne(task => task.Category);

            //One Category can have many tasks
            builder.Entity<Task>().HasOne(task => task.Category).WithMany(category => category.Tasks);
        }

        //Fluent API Relationships go right here
        public DbSet<MVC_Core_Entity_ToDoList_01.Models.AthleticsMeetings> AthleticsMeetings { get; set; }
    }
}
