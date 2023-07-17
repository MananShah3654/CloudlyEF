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
            CreateMap<Customers, CustomerDto>().ReverseMap();
        }

        
    }

}