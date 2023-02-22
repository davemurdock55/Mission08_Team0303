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
        public TaskContext (DbContextOptions<TaskContext> options) : base (options)
        {
            // leave blank for now. accomplishes inheritance
        }

        public DbSet<Task> responses;
    }
}
