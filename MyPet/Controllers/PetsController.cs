using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyPet.Services.Pets;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPet.Controllers
{
    [Route("api/pets")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly IPetRepository _petService;

        public PetsController(IPetRepository repository)
        {
            _petService = repository; 
        }

        [HttpGet]
        public IActionResult GetPets() 
        {
            var pets = _petService.AllPets();
            
            return Ok(pets);
        }
        [HttpGet("{id}")]
        public IActionResult GetPet(int id)
        {
            var pet = _petService.GetPet(id);
            if (pet is null)
            {
                return NotFound();
            }
            return Ok(pet);
        }

    }
}
