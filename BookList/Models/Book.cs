using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookList.Models
{
    public class Book
    {
        // Data annotation attributes
        [Key]
        public int Id { get; set; }

        [Display(Name="Book Name")]
        [Required]
        public string Name { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
    }
}
