using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home4Pets.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(13)]
        public string Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string Role { get; set; } // Adopter or PetOwner

        public List<Pet> Pets { get; set; } 
        public List<AdoptionRequest> AdoptionRequests { get; set; }
    }
}


