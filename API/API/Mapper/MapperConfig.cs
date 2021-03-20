using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using API.Models;
using API.Controllers.Requests;

namespace API.Mapper
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Haandvaerker, HaandVaerkerRequest>();
            CreateMap<Vaerktoejskasse, VaerktoejsKasseRequest>();
            CreateMap<Vaerktoej, VaerkToejRequest>();
        }
    }
}
