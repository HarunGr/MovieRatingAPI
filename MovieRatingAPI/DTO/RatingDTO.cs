using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingAPI.DTO
{
    public class RatingDTO
    {
        public decimal Id { get; set; }
        public decimal MovieId { get; set; }
        public decimal? Rating { get; set; }
        public decimal? Votes { get; set; }
    }
}
