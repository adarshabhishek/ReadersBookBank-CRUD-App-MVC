using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ReadersBookBank.DAL.Models
{
    public class BookDetail
    {
        [Key]
        public int  Id { get; set; }
        [Required]
        [StringLength(35)]
        public string BookName { get; set; }
        [Required]
        [StringLength(35)]
        public string Genre { get; set; }
        [Required]
        public bool AvailabilityStatus { get; set; }

    }
}
