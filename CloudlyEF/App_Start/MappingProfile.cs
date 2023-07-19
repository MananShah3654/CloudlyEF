using AutoMapper;
using CloudlyEF.Models;
using CloudlyEF.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudlyEF.App_Start
{

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            CreateMap<Customers, CustomerDto>().ReverseMap();
            CreateMap<Movies, MovieDto>().ReverseMap();

            // Dto to Domain
            CreateMap<CustomerDto, Customers>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            CreateMap<MovieDto, Movies>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }

        
    }

}