using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyPet.Models;
using MyPet.Services.Owners;
using MyPet.Services.Models;
using System.Collections.Generic;
using AutoMapper;

namespace MyPet.Controllers
{
    [Route("api/owners")]
    [ApiController]
    public class OwnersController : ControllerBase
    {
        private readonly IOwnerRepository _service;
        private readonly IMapper _mapper;

        public OwnersController(IOwnerRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        //[HttpGet]
        //public IActionResult GetOwners()
        //{
        //    var owners = _service.GetAllOwners();
        //    var ownersDto = new List<OwnerDto>();
        //    foreach (var owner in owners)
        //    {
        //        ownersDto.Add(new OwnerDto
        //        {
        //            Id = owner.Id,
        //            FullName=owner.FullName,
        //            PhoneNumber=owner.PhoneNumber,
        //            Address = $"{owner.AddressNo},{owner.Street},{owner.City}"
        //        });

        //    }

        //    return Ok(ownersDto);
        //}

        [HttpGet]
        public ActionResult<ICollection<OwnerDto>> GetOwners()
        {
            var owners = _service.GetAllOwners();
            
            //var ownersDto = new List<OwnerDto>();

            //foreach (var owner in owners)
            //{
            //    ownersDto.Add(new OwnerDto
            //    {
            //        Id = owner.Id,
            //        FullName = owner.FullName,
            //        PhoneNumber = owner.PhoneNumber,
            //        Address = $"{owner.AddressNo},{owner.Street},{owner.City}"
            //    });

            //}

            //using automapper

           var mappedOwners= _mapper.Map<ICollection<OwnerDto>>(owners);

            return Ok(mappedOwners);
        }

        [HttpGet("{id}")]
        public IActionResult GetOwner(int id)
        {
            var owner = _service.GetOwner(id);
            if (owner is null) {
                return NotFound();
            }

            var mappedOwners = _mapper.Map<OwnerDto>(owner);
            return Ok(mappedOwners);
        }


    }
}
