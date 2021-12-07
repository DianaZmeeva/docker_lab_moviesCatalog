using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCatalog.API.Models.Api.Movies
{
    public class MoviesPagedListModel : MoviesListModel
    {
        public PageInfoModel PageInfo { get; set; }
    }
}
