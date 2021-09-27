using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingAPI.DTO
{
    public class MovieDTO
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public string Actors { get; set; }
        public byte[] Poster { get; set; }
    }
}
