using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MovieRatingAPI.DTO;
using MovieRatingAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingAPI.Services
{
    public class MovieService
    {
        readonly MovieContext _context;
        readonly IMapper _mapper;
        readonly Dictionary<int, string> searchDict = new Dictionary<int, string>()
        {
            {1, "at least" },
            {2, "stars" },
            {3, "older" },
            {4, "after" }
        };
        public MovieService(MovieContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<MovieDTO>> GetTopRated(int page)
        {
            var movies = await _context.Movies.OrderByDescending(x => x.Rating).Skip(page * 10).Take(10).ToListAsync();
            return _mapper.Map<List<MovieDTO>>(movies);
        }
        
        public async Task<List<MovieDTO>> Search(string term)
        {
            var movies = await _context.Movies.Where(x => x.Title.ToLower().Contains(term)).ToListAsync();
            movies.AddRange(_context.Movies.Where(x => x.Actors.ToLower().Contains(term)));
            movies.AddRange(_context.Movies.Where(x => x.Description.ToLower().Contains(term)));
            movies.AddRange(_context.Movies.Where(x => x.Director.ToLower().Contains(term)));
            return _mapper.Map<List<MovieDTO>>(movies.OrderByDescending(x => x.Rating));
        }

        public async Task<List<MovieDTO>> GetAllMovies()
        {
            await Task.Yield();
            return _mapper.Map<List<MovieDTO>>(_context.Movies);
        }
    }
}
