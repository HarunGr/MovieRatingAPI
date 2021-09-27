using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRatingAPI.DTO;
using MovieRatingAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingAPI.Controllers
{
    [Route("api/rating")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        readonly RatingService _ratingService;

        public RatingController(RatingService ratingService)
        {
            _ratingService = ratingService;
        }

        [HttpPost]
        public async Task<IActionResult> Rate([FromBody]RatingVote vote)
        {
            await _ratingService.UpdateRating(vote.MovieId.GetValueOrDefault(), vote.Value.GetValueOrDefault());
            return Ok();
        }

    }
}
