using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.Models
{
    public class Book // All properties in the Book class are going to be required
    {
        [Key][Required] // We want the BookID to act as a primary key
        public int BookID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int NumPages { get; set; } // We want to add the number of pages
        [Required]
        public string AuthorFirst { get; set; }
        [Required]
        public string AuthorLast { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required] // We want the ISBN number to be in a specific format xxx-xxxxxxxxxx
        [RegularExpression(@"^?([0-9]{3})?[-.●]?([0-9]{10})$", ErrorMessage = "The ISBN field is not valid. You must use the format xxx-xxxxxxxxxx")]
        public string ISBN { get; set; }
        [Required]
        public bool Fiction { get; set; } 
        [Required]                         
        public string Category { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
