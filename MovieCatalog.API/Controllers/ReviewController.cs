using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MovieCatalog.API.Data;
using MovieCatalog.API.Models.Api.Reviews;
using MovieCatalog.API.Models.Data;

namespace MovieCatalog.API.Controllers
{
    [Authorize]
    [Route("api")]
    public class ReviewController : BaseApiController
    {
        private readonly UserManager<User> _userManager;

        public ReviewController(ApplicationDbContext context, 
            UserManager<User> userManager) : base(context)
        {
            _userManager = userManager;
        }

        [HttpPost("/movie/{movieId}/review/add")]
        public async Task<ActionResult> AddReview(Guid movieId, ReviewModifyModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user == null)
            {
                return StatusCode(405);
            }

            var movie = await Context.Movies.Include(m=>m.Reviews).FirstOrDefaultAsync(x => x.Id == movieId);
            if (movie == null)
            {
                return NotFound();
            }

            if (movie.Reviews == null)
            {
                movie.Reviews = new List<Review>();
            }
            else
            {
                if (movie.Reviews.Any(x => x.AuthorId == user.Id))
                {
                    return new BadRequestObjectResult(new { Message = "User has already had review for this movie" });
                }
            }

            if (!ModelState.IsValid)
            {
                return new BadRequestObjectResult(new { Message = "Can't update user profile", Errors = ModelState });
            }

            var review = new Review
            {
                ReviewText = model.ReviewText,
                Rating = model.Rating,
                IsAnonymous = model.IsAnonymous,
                MovieId = movieId,
                AuthorId = model.IsAnonymous ? null : user.Id
            };

            Context.Reviews.Add(review);
            await Context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("/movie/{movieId}/review/{id}/edit")]
        public async Task<ActionResult> EditReview(Guid movieId, Guid id, ReviewModifyModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user == null)
            {
                return StatusCode(405);
            }

            var review = await Context.Reviews.FirstOrDefaultAsync(x => x.MovieId == movieId && x.Id == id);
            if (review == null)
            {
                return NotFound();
            }

            if (review.AuthorId != user.Id)
            {
                return StatusCode(405);
            }

            if (!ModelState.IsValid)
            {
                return new BadRequestObjectResult(new { Message = "Can't update user profile", Errors = ModelState });
            }

            if (!review.IsAnonymous && model.IsAnonymous)
            {
                var userReview =
                    await Context.Reviews.FirstOrDefaultAsync(x => x.MovieId == movieId && x.AuthorId == user.Id);
                if (userReview != null)
                {
                    return new BadRequestObjectResult(new { Message = "User has already had review for this movie" });
                }
            }

            review.ReviewText = model.ReviewText;
            review.Rating = model.Rating;
            review.IsAnonymous = model.IsAnonymous;
            review.AuthorId = model.IsAnonymous ? null : user.Id;


            Context.Reviews.Update(review);
            await Context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("/movie/{movieId}/review/{id}/delete")]
        public async Task<ActionResult> DeleteReview(Guid movieId, Guid id)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user == null)
            {
                return StatusCode(405);
            }

            var review = await Context.Reviews.FirstOrDefaultAsync(x => x.MovieId == movieId && x.Id == id);
            if (review == null)
            {
                return NotFound();
            }

            if (review.AuthorId != user.Id)
            {
                return StatusCode(405);
            }

            Context.Reviews.Remove(review);
            await Context.SaveChangesAsync();
            return Ok();
        }
    }
}
