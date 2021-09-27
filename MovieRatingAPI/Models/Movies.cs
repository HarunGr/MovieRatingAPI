using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRatingAPI.Models
{
    [Table("MOVIES")]
    public class Movies
    {
        [Key]
        [Column("ID")]
        public decimal Id { get; set; }

        [Column("TITLE")]
        public string Title { get; set; }

        [Column("DIRECTOR")]
        public string Director { get; set; }

        [Column("ACTORS")]
        public string Actors { get; set; }

        [Column("POSTER")]
        public string Poster { get; set; }

        [Column("RATING")]
        public decimal? Rating { get; set; }

        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [Column("DATE")]
        public DateTime? Date { get; set; }
    }
}
