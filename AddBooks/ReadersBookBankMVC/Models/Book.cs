using System.ComponentModel.DataAnnotations;

namespace ReadersBookBankMVC.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(35)]
        public string BookName { get; set; }
        [Required]
        [StringLength(35)]
        public string Genre { get; set; }
        public bool AvailabilityStatus { get; set; }
    }
}
