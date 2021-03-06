using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieCatalog.API.Constants;
using MovieCatalog.API.Data;
using MovieCatalog.API.Models.Api;
using MovieCatalog.API.Models.Api.Genres;
using MovieCatalog.API.Models.Api.Movies;
using MovieCatalog.API.Models.Api.Reviews;
using MovieCatalog.API.Models.Api.Users;

namespace MovieCatalog.API.Controllers
{
    [Route("api/movies")]
    public class MovieController : BaseApiController
    {
        public MovieController(ApplicationDbContext context) : base(context)
        {
        }

        [HttpGet("{page}")]
        public async Task<MoviesPagedListModel> GetMovies(int page=1)
        {
            var pageSize = ConfigurationConstants.DefaultPageSize;
            var movies = Context.Movies
                .Include(m=>m.Genres)
                .Include(m=>m.Reviews)
                .OrderByDescending(x=>x.Name);

            PageInfoModel pageInfo = new PageInfoModel()
            {
                CurrentPage = page, 
                PageSize = pageSize,
                PageCount = (int)Math.Ceiling((double)movies.Count() / (double)pageSize)
            };

            var t = movies.ToList();

            return new MoviesPagedListModel
            {
                Movies = movies.Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .Select(x => new MovieElementModel
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Poster = x.PosterLink,
                        Year = x.Year,
                        Country = x.Country,
                        Genres = x.Genres.Select(g => new GenreModel
                        {
                            Id = g.Id,
                            Name = g.Name
                        }).ToList(),
                        Reviews = x.Reviews.Select(r => new ReviewShortModel
                        {
                            Id = r.Id,
                            Rating = r.Rating
                        }).ToList()
                    }).ToList(),
                PageInfo = pageInfo
            };

        }


        [HttpGet("details/{id}")]
        public async Task<ActionResult<MovieDetailsModel>> GetMovie(Guid id)
        {
            var movie = await Context.Movies
                .Include(m => m.Genres)
                .Include(m => m.Reviews)
                .ThenInclude(r=>r.Author)
                .FirstOrDefaultAsync(x => x.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            return new MovieDetailsModel
            {
                Id = movie.Id,
                Name = movie.Name,
                Poster = movie.PosterLink,
                Year = movie.Year,
                Country = movie.Country,
                Genres = movie.Genres.Select(g => new GenreModel
                {
                    Id = g.Id,
                    Name = g.Name
                }).ToList(),
                Time = movie.Time,
                Tagline = movie.Tagline,
                Director = movie.Director,
                Budget = movie.Budget,
                Fees = movie.Fees,
                AgeLimit = movie.AgeLimit,
                Reviews = movie.Reviews.Select(r => new ReviewModel
                {
                    Id = r.Id,
                    ReviewText = r.ReviewText,
                    Rating = r.Rating,
                    IsAnonymous = r.IsAnonymous,
                    CreateDateTime = r.CreateDateTime,
                    Author = r.AuthorId == null
                        ? null
                        : new UserShortModel
                        {
                            UserId = (Guid)r.AuthorId,
                            NickName = r.Author?.UserName,
                            Avatar = r.Author?.Avatar
                        }
                }).ToList()
            };
        }

    }
}
