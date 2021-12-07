using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCatalog.API.Models.Api.Movies
{
    public class MoviesListModel
    {
        public List<MovieElementModel> Movies { get; set; } = new List<MovieElementModel>();
    }
}
