using System;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //without ignoring the Id property in mapping Customer to CustomerDto it will throw an exception saying that Id is a key value
            //and it shouldn't be changed. Same applies to Movie and MovieDto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(m => m.Id, o => o.Ignore())
                .ForMember(m => m.AddedDate, opt => opt.UseValue(DateTime.Now));

            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();
        }
    }
}