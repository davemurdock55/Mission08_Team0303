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

        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Task>().HasData(
                new Task
                {
                    TaskId = 1,
                    task = "Do laundry",
                    DueDate = "Tuesday",
                    Quadrant = 4,
                    Category = "Home",
                    Completed = false
                },
                new Task
                {
                    TaskId = 2,
                    task = "Write talk",
                    DueDate = "Sunday",
                    Quadrant = 2,
                    Category = "Church",
                    Completed = false
                },
                new Task
                {
                    TaskId = 3,
                    task = "Go to work",
                    Quadrant = 1,
                    Category = "Work",
                    Completed = true
                }
            );
        }
    }
}
