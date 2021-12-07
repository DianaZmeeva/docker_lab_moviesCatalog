using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MovieCatalog.API.Data;
using MovieCatalog.API.Models.Api.Genres;
using MovieCatalog.API.Models.Api.Movies;
using MovieCatalog.API.Models.Data;

namespace MovieCatalog.API.Controllers
{
    [Authorize]
    [Route("api/favorites")]
    public class FavoriteMoviesController : BaseApiController
    {
        private readonly UserManager<User> _userManager;
        public FavoriteMoviesController(ApplicationDbContext context, 
            UserManager<User> userManager) : base(context)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<ActionResult<MoviesListModel>> GetMovies()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user == null)
            {
                return StatusCode(405);
            }

            var movies = await Context.Users
                .Where(x => x.Id == user.Id)
                .Include(u => u.FavoriteMovies)
                .ThenInclude(m=>m.Genres)
                .SelectMany(x => x.FavoriteMovies)
                .Select(x=>new MovieElementModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Poster = x.PosterLink,
                    Year = x.Year,
                    Country = x.Country,
                    Rating = x.Rating,
                    Genres = x.Genres.Select(g=>new GenreModel
                    {
                        Id = g.Id,
                        Name = g.Name
                    }).ToList()
                }).ToListAsync();

            return new MoviesListModel { Movies = movies };
        }

        [HttpPost("{id}/add")]
        public async Task<ActionResult> AddFavoriteMovie(Guid id)
        {
            var movie = await Context.Movies.FirstOrDefaultAsync(x => x.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            var user = await Context.Users
                .Include(u => u.FavoriteMovies)
                .FirstOrDefaultAsync(x => x.UserName == User.Identity.Name);

            if (user == null)
            {
                return StatusCode(405);
            }


            if (user.FavoriteMovies == null)
            {
                user.FavoriteMovies = new List<Movie>();
            }
            else
            {
                if (user.FavoriteMovies.Any(x => x.Id == id))
                {
                    return new BadRequestObjectResult(new { Message = "Movie have already added to favorites" });
                }
            }

            user.FavoriteMovies.Add(movie);
            await Context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}/delete")]
        public async Task<ActionResult> DeleteFavoriteMovie(Guid id)
        {
            var user = await Context.Users
                .Include(u => u.FavoriteMovies)
                .FirstOrDefaultAsync(x => x.UserName == User.Identity.Name);

            if (user == null)
            {
                return StatusCode(405);
            }


            if (user.FavoriteMovies == null || user.FavoriteMovies.All(x => x.Id != id))
            {
                return new BadRequestObjectResult(new { Message = "Not-existing user favorite movie"});
            }

            var deletedMovie = user.FavoriteMovies.FirstOrDefault(x => x.Id == id);
            user.FavoriteMovies.Remove(deletedMovie);
            Context.Users.Update(user);
            await Context.SaveChangesAsync();
            return Ok();
        }


    }
}
