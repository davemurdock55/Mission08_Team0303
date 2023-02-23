using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission08_Team0303.Models
{
    public class TaskContext : DbContext
    {
        // Constructor
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {
            // leave blank for now. accomplishes inheritance
        }

        public DbSet<Tasks> Tasks { get; set; }

        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
               new Category { CategoryId = 1, CategoryName = "Home" },
               new Category { CategoryId = 2, CategoryName = "School" },
               new Category { CategoryId = 3, CategoryName = "Work" },
               new Category { CategoryId = 4, CategoryName = "Church" }
             );

            mb.Entity<Tasks>().HasData(
                new Tasks
                {
                    TaskId = 1,
                    task = "Do laundry",
                    DueDate = "Tuesday",
                    Quadrant = 4,
                    CategoryId = 1,
                    Completed = false
                },
                new Tasks
                {
                    TaskId = 2,
                    task = "Write talk",
                    DueDate = "Sunday",
                    Quadrant = 2,
                    CategoryId = 4,
                    Completed = false
                },
                new Tasks
                {
                    TaskId = 3,
                    task = "Go to work",
                    Quadrant = 1,
                    CategoryId = 3,
                    Completed = true
                }
            );
        }
    }
}
