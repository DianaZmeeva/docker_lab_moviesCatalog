using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieCatalog.API.Models.Api.Users;

namespace MovieCatalog.API.Models.Api.Reviews
{
    public class ReviewModel : ReviewShortModel
    {
        public string ReviewText { get; set; }
        public bool IsAnonymous { get; set; }
        public DateTime CreateDateTime { get; set; }
        public UserShortModel Author { get; set; }
    }

    public class ReviewShortModel
    {
        public Guid Id { get; set; }
        public int Rating { get; set; }
    }
}
