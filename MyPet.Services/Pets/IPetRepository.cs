using MyPet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPet.Services.Pets
{
    public interface IPetRepository
    {
        public List<Pet> AllPets();

        public Pet GetPet(int id);
    }
}
