using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LibraryManagementSystem.Models;


namespace LibraryManagementSystem.Models
{
    public class Loan
    {
        public int LoanId { get; set; }

        [Required]
        public int BookId { get; set; }
        public Book Book { get; set; } = null!;

        [Required]
        public int MemberId { get; set; }
        public Member Member { get; set; } = null!; // Ensure 'Member' class exists in the correct namespace  

        public DateTime LoanDate { get; set; } = DateTime.Now;
        public DateTime? ReturnDate { get; set; }

        [NotMapped]
        public int DaysLate => ReturnDate.HasValue ? Math.Max(0, (ReturnDate.Value - LoanDate).Days - 7) : 0;

        [NotMapped]
        public decimal LateFee => DaysLate * 1.00m;
    }
}
