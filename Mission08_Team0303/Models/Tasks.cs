using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission08_Team0303.Models
{
    public class Tasks
    {
        // id necessary for database
        [Key]
        [Required]
        public int TaskId { get; set; }

        // task (required)
        [Required]
        public string task { get; set; }

        // due date
        public string DueDate { get; set; }

        // quadrant (required)
        [Required]
        [Range(1, 4, ErrorMessage = "Quadrant must be a value between 1 and 4.")]
        public int Quadrant { get; set; }

        // category (dropdown containing options: Home, School, Work, Church) Foreign Key Relationship
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // completed (True/False)
        public bool Completed { get; set; }
    }
}
