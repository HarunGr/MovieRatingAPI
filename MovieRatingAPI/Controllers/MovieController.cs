using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRatingAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingAPI.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        readonly MovieService _movieService;
        public MovieController(MovieService movieService)
        {
            _movieService = movieService;
        }

        [Route("top/{page}")]
        [HttpGet]
        public async Task<IActionResult> TopRated(int page)
        {
            return Ok(await _movieService.GetTopRated(page));
        }

        [Route("search/{term}")]
        [HttpGet]
        public async Task<IActionResult> Search(string term)
        {
            return Ok(await _movieService.Search(term));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _movieService.GetAllMovies());
        }
    }
}
