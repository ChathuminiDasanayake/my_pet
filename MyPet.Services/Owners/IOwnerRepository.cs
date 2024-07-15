using MyPet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPet.Services.Owners
{
    public interface IOwnerRepository
    {
        public List<Owner> GetAllOwners();
        public Owner GetOwner(int id);




    }
}
