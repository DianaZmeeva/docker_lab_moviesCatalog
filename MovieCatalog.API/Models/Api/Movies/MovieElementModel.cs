using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieCatalog.API.Models.Api.Genres;
using MovieCatalog.API.Models.Api.Reviews;

namespace MovieCatalog.API.Models.Api.Movies
{
    public class MovieElementModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Poster { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public List<GenreModel> Genres { get; set; } = new List<GenreModel>();
        public List<ReviewShortModel> Reviews { get; set; } = new List<ReviewShortModel>();
    }
}
