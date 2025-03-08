using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home4Pets.Models
{
    public class AdoptionRequest
    {
        [Key]
        public int AdoptionRequestId { get; set; }

        [ForeignKey("Pet")]
        public int PetId { get; set; }
        public Pet Pet { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; } //  Adopter
        public User User { get; set; }

        public DateTime RequestDate { get; set; }

        [Required]
        public string Status { get; set; } // Pending or Approved or Rejected

        public DateTime? ApprovalDate { get; set; }

        public string Remarks { get; set; }
    }

}
