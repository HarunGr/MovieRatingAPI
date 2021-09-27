using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingAPI.DTO
{
    public class RatingVote
    {
        public decimal? MovieId { get; set; }
        public decimal? Value { get; set; }
    }
}
