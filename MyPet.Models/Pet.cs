using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;

namespace MyPet.Models
{
    public class Pet
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        public string Color { get; set; }
        public string Catogery { get; set; }

        public PetGender Gender { get; set; }
        public DateTime Date { get; set; }
        public PetStatus Status { get; set; } // Found, Not Found

        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
