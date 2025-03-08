using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home4Pets.Models
{
    public class PetType
    {
        [Key]
        public int PetTypeId { get; set; }

        [Required]
        [StringLength(100)]
        public string PetTypeName { get; set; }

        public List<Pet> Pets { get; set; }
    }
}
