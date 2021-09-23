﻿using API.DTO;
using API.Model;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Mappings
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Developer, DeveloperDTO>()  //Map from Developer Object to DeveloperDTO object
                .ForMember(dest => dest.Compensation, source => source.MapFrom(source => source.Salary)) //Specific Mapping
                .ForMember(dest => dest.IsEmployed, source => source.MapFrom(source => source.Salary > 0 ? true : false)) //Conditional Mapping
                .ReverseMap();
            CreateMap<Address, AddressDTO>();
        }
    }
}
