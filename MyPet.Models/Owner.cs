using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPet.Models
{
    public class Owner
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string FullName { get; set; }
        [MaxLength(10)]
        public string PhoneNumber { get; set; }
        [MaxLength(10)]
        public string AddressNo { get; set; }
        [MaxLength(200)]
        public string Street { get; set; }
        [Required]
        [MaxLength(100)]
        public string City { get; set; }

        public ICollection <Pet> Pets { get; set; } = new List<Pet>();
    }
}
