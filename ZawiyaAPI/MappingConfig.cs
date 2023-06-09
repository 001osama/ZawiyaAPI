﻿using AutoMapper;
using ZawiyaAPI.Models;
using ZawiyaAPI.Models.Dto;

namespace ZawiyaAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Product, ProductCreateDTO>().ReverseMap();
            CreateMap<Product, ProductUpdateDTO>().ReverseMap();

            CreateMap<Bid, BidDTO>().ReverseMap();
            CreateMap<Bid, BidCreateDTO>().ReverseMap();

            CreateMap<ApplicationUser, UserDTO>().ReverseMap();   
        }
    }
}
