using MyPet.Models;
using System.Collections.Generic;
using System;

namespace MyPet.Services
{
    public class PetService
    {
        // Get all Pets

        public List<Pet> AllPets()
        {
            var pets = new List<Pet>();

            var pet1 = new Pet
            {
                Id = 1,
                Name = "Blacky",
                Catogery = "Dog",
                Color = "Black & White",
                Date = DateTime.Now,
                Status = PetStatus.Found

            };
            pets.Add(pet1);
            var pet2 = new Pet
            {
                Id = 2,
                Name = "Chooty",
                Catogery = "Dog",
                Color = "Brown",
                Date = DateTime.Now,
                Status = PetStatus.Found

            };
            pets.Add(pet2);
            var pet3 = new Pet
            {
                Id = 3,
                Name = "Kelly",
                Catogery = "Dog",
                Color = "Brown & White",
                Date = DateTime.Now,
                Status = PetStatus.Found

            };
            pets.Add(pet3);
            var pet4 = new Pet
            {
                Id = 4,
                Name = "Kikki",
                Catogery = "Dog",
                Color = "Black & White",
                Date = DateTime.Now,
                Status = PetStatus.NotFound

            };
            pets.Add(pet4);

            return pets;
        }
    }
}
