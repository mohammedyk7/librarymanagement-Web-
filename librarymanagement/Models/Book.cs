using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Author { get; set; } = string.Empty;

        public string Genre { get; set; } = string.Empty;

        public int Year { get; set; }

        public int AvailableCopies { get; set; }

        public List<Loan>? Loans { get; set; }
    }
}
