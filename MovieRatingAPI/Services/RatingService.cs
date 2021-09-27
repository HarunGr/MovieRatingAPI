using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MovieRatingAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingAPI.Services
{
    public class RatingService
    {
        readonly MovieContext _movieContext;
        readonly IMapper _mapper;
        public RatingService(MovieContext context, IMapper mapper)
        {
            _mapper = mapper;
            _movieContext = context;
        }

        public async Task UpdateRating(decimal id, decimal userRating)
        {
            var rating = await _movieContext.Ratings.FirstOrDefaultAsync(x => x.MovieId == id);
            var movie = _movieContext.Movies.FirstOrDefault(x => x.Id == rating.Id);
            rating.Rating = (rating.Rating + userRating) / (rating.Votes);
            rating.Votes++;
            movie.Rating = rating.Rating;
            await _movieContext.SaveChangesAsync();
        }
    }
}
