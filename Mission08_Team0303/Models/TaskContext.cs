using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission08_Team0303.Models
{
    public class Task
    {
        // id necessary for database
        [Key]
        [Required]
        int TaskId { get; set; }

        // task (required)
        [Required]
        string Task { get; set; }

        // due date
        string DueDate { get; set; }
        
        // quadrant (required)
        [Required]
        string Quadrant { get; set; }

        // category (dropdown containing options: Home, School, Work, Church)
        string Category { get; set; }
        
        // completed (True/False)
        bool Completed { get; set; }
    }
}
