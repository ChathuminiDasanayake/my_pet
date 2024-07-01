using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyPet.Models;
using MyPet.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private PetService _petService;

        public PetsController()
        {
            _petService = new PetService(); 
        }

        [HttpGet("{id?}")]
        public IActionResult GetPet(int? id) 
        {
            var pets = _petService.AllPets();
            if (id is null) return Ok(pets);

            pets = pets.Where(p => p.Id == id).ToList();
            return Ok(pets);
        }

        
        
    }
}
