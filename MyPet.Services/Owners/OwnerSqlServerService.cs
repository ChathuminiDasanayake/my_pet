using MyPet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPet.DataAccess;

namespace MyPet.Services.Owners
{
    
    public class OwnerSqlServerService : IOwnerRepository
    {
        private readonly PetDbContext _context = new PetDbContext();
        public List<Owner> GetAllOwners()
        {
            return _context.Owners.ToList();
        }

        public Owner GetOwner(int id)
        {
            return _context.Owners.Find(id);
        }
    }
}
