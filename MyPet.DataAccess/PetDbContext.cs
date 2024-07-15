using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using MyPet.Models;

namespace MyPet.DataAccess
{
    public class PetDbContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Owner> Owners { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost; Database= MyPetDb; User Id =sa; Password=123; TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner>().HasData(new Owner[]
            {
                new Owner {Id = 1, FullName = "Chathumini Dasanayake" ,PhoneNumber = "0712400284", AddressNo ="07", Street="Wela", City="Polgahawela"},
                new Owner {Id = 2, FullName = "Nadeesh Fernando",PhoneNumber = "0774964200",AddressNo ="08", Street="Wela", City="Polgahawela" },
                new Owner {Id = 3, FullName = "Chandrakeerthi Dasanayake",PhoneNumber = "0718070325",AddressNo ="09", Street="Wela", City="Polgahawela" },
                new Owner {Id = 4, FullName = "Nilanthi Adikari" ,PhoneNumber = "0718195376",AddressNo ="10", Street="Wela", City="Polgahawela"},
                new Owner {Id = 5, FullName = "Anjana Dasanayake" ,PhoneNumber = "0713620646",AddressNo ="11", Street="Wela", City="Polgahawela"}

            });

            modelBuilder.Entity<Pet>().HasData(new Pet[]
            {
                new Pet
                {
                    Id = 1,
                    Name = "Blacky",
                    Catogery = "Dog(DB)",
                    Color = "Black & White",
                    Gender=PetGender.Male,
                    Date = DateTime.Now,
                    Status = PetStatus.Found,
                    OwnerId = 1
                },
                new Pet
                {
                    Id = 2,
                    Name = "Chooty",
                    Catogery = "Dog",
                    Color = "Brown",
                    Gender=PetGender.Female,
                    Date = DateTime.Now,
                    Status = PetStatus.Found,
                    OwnerId = 2

                },
                new Pet
                {
                    Id = 3,
                    Name = "Kelly",
                    Catogery = "Dog",
                    Color = "Brown and White",
                    Gender=PetGender.Female,
                    Date = DateTime.Now,
                    Status = PetStatus.Found,
                    OwnerId = 3

                },
                new Pet
                {
                    Id = 4,
                    Name = "Kikki",
                    Catogery = "Dog",
                    Color = "Black",
                    Gender=PetGender.Female,
                    Date = DateTime.Now,
                    Status = PetStatus.Found,
                    OwnerId = 4

                },
                new Pet
                {
                    Id = 5,
                    Name = "Kitty",
                    Catogery = "Cat",
                    Color = "Ash",
                    Gender=PetGender.Female,
                    Date = DateTime.Now,
                    Status = PetStatus.Found,
                    OwnerId = 5

                },
                 new Pet
                {
                    Id = 6,
                    Name = "Teena",
                    Catogery = "Dog",
                    Color = "Black",
                    Gender=PetGender.Male,
                    Date = DateTime.Now,
                    Status = PetStatus.Found,
                    OwnerId = 1

                }

            });

            
        }
    }
}
