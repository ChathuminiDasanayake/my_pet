using MyPet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPet.DataAccess;

namespace MyPet.Services.Pets
{
    public class PetSqlServerService : IPetRepository
    {
        private readonly PetDbContext _context = new PetDbContext();
        public List<Pet> AllPets()
        {
            return _context.Pets.ToList();
        }

        public Pet GetPet(int id)
        {
            return _context.Pets.Find(id);
        }
    }
}
