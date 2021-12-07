using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieCatalog.API.Models.Api.Reviews;

namespace MovieCatalog.API.Models.Api.Movies
{
    public class MovieDetailsModel : MovieElementModel
    {
        public int Time { get; set; }
        public string Tagline { get; set; }
        public string Director { get; set; }
        public int? Budget { get; set; }
        public int? Fees { get; set; }
        public int AgeLimit { get; set; }
        public List<ReviewModel> Reviews { get; set; } = new List<ReviewModel>();
    }
}
