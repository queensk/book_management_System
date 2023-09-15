using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace book_management_System.Models
{
    public class Book
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required(ErrorMessage= "please enter title")]
        public string Title { get; set; } 
        [Required(ErrorMessage= "please enter description")]
        public string Description { get; set; }
        // public string Category { get; set; }
        // public int Pages { get; set; }
        // public string Language { get; set; }
        [Required(ErrorMessage= "please enter author")]
        public List<Author> Authors { get; set; } = new List<Author>();
    }

    public class Author
    {
        public int Id {get; set;}
        [Required(ErrorMessage= "please enter author name")]
        public string Name {get; set;}
    }
}