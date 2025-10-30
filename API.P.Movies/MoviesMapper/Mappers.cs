﻿using API.P.Movies.DAL.Models;
using API.P.Movies.DAL.Models.Dtos;
using AutoMapper;

namespace API.P.Movies.MoviesMapper
{
    public class Mappers : Profile
    {
        public Mappers()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryCreateDto>().ReverseMap();
        }
    }
}
