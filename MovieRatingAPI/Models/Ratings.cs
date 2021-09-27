using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingAPI.Models
{
    [Table("RATINGS")]
    public class Ratings
    {
        [Key]
        [Column("ID")]
        public decimal Id { get; set; }

        [Column("MOVIE_ID")]
        public decimal MovieId { get; set; }

        [Column("RATING")]
        public decimal? Rating { get; set; }

        [Column("VOTES")]
        public decimal? Votes { get; set; }
    }
}
