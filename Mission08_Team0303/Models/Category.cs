using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission08_Team0303.Models
{
    public class Category
    {
        [Key]
        [Required(ErrorMessage = "You must select a category")]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
