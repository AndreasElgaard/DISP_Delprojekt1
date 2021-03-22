using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using API.Models;
using API.Controllers.Requests;
using API.Controllers.Responses;

namespace API.Mapper
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<HaandVaerkerRequest, Haandvaerker>();
            CreateMap<VaerktoejsKasseRequest, Vaerktoejskasse>();
            CreateMap<VaerkToejRequest, Vaerktoej>();
            CreateMap<Haandvaerker, HaandVaerkerResponse>();
            CreateMap<Vaerktoejskasse, VaerktoejsKasseResponse>();
            CreateMap<Vaerktoej, VaerktoejsResponse>();
        }
    }
}
