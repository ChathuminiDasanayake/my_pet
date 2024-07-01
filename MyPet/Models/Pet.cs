using Microsoft.VisualBasic;
using System;

namespace MyPet.Models
{
    public class Pet
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Catogery { get; set; }
        public DateTime Date { get; set; }
        public PetStatus Status { get; set; } // Found, Not Found
    }
}
