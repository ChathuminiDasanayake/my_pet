using AutoMapper;
using MyPet.Models;
using MyPet.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPet.Services.Profiles
{
    public class OwnerProfile : Profile
    {
        public OwnerProfile()
        {
            CreateMap<Owner, OwnerDto>()
                .ForMember(dest => dest.Address,
                opt => opt.MapFrom(src => $"{src.AddressNo},{src.Street},{src.City}"));
        }



    }
}
