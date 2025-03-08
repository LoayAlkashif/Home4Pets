using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home4Pets.Models
{
    public class Pet
    {
        [Key]
        public int PetId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; } // PetOwner
        public User User { get; set; }

        [Required]
        [StringLength(100)]
        public string PetName { get; set; }

        [ForeignKey("PetType")]
        public int PetTypeId { get; set; }
        public PetType PetType { get; set; }

        public string Description { get; set; }

        public int Age { get; set; }

        [Required]
        public string Gender { get; set; } // Male or Female

        [Required]
        public string HealthStatus { get; set; } // Healthy or Needs Treatment

        [Required]
        public string VaccinationStatus { get; set; } // Vaccinated or Not Vaccinated

        [Required]
        public string AdoptionStatus { get; set; } // Available or Pending or Adopted

        public DateTime DateRegistered { get; set; }

        public List<AdoptionRequest> AdoptionRequests { get; set; }
    }
}
