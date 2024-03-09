using AutoMapper;
using Business.Requests.Brands;
using Business.Responses.Brands;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Business.Profiles.Brands
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Brand, CreateBrandRequest>().ReverseMap();
            CreateMap<Brand, CreateBrandResponse>().ReverseMap();
            CreateMap<Brand, GetAllBrandResponse>().ReverseMap();
            CreateMap<Brand, DeleteBrandRequest>().ReverseMap();

        }
    }
}