using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace StudentAdminPortal.API.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModels.Student, DomainModels.Student>().ReverseMap();

            CreateMap<DataModels.Gender, DomainModels.Gender>().ReverseMap();

            CreateMap<DataModels.Address, DomainModels.Address>().ReverseMap();
        }
    }
}
