using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home4Pets.Models
{
    public class Adoption
    {
        [Key]
        public int AdoptionId { get; set; }

        [ForeignKey("Pet")]
        public int PetId { get; set; }
        public Pet Pet { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; } // الـ Adopter
        public User User { get; set; }

        public DateTime AdoptionDate { get; set; }

        public string Remarks { get; set; }
    }
}
