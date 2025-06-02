using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace LibraryManagementSystem.Models
{
    public class Member
    {
        public int MemberId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public DateTime JoinDate { get; set; } = DateTime.Now;

        public List<Loan>? Loans { get; set; }
    }
}
