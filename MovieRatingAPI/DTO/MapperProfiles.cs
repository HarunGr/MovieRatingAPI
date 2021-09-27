using AutoMapper;
using MovieRatingAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingAPI.DTO
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<MovieDTO, Movies>();
            CreateMap<Movies, MovieDTO>();
            CreateMap<RatingDTO, Ratings>();
            CreateMap<Ratings, RatingDTO>();
        }
    }
}
