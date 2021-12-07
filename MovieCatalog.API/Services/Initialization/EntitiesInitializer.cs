using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MovieCatalog.API.Constants;
using MovieCatalog.API.Data;
using MovieCatalog.API.Models.Data;

namespace MovieCatalog.API.Services.Initialization
{
    public static class EntitiesInitializer
    {
        public static async Task Initialize(UserManager<User> userManager, ApplicationDbContext context)
        {
            #region Initialize new users
            foreach (var user in EntityInitialization.SystemUsers)
            {
                var existingUser = await userManager.FindByNameAsync(user.UserName);
                if (existingUser == null)
                {
                    var identityUser = new User()
                    {
                        Name = user.Name,
                        UserName = user.UserName,
                        Email = user.Email,
                        BirthDate = user.BirthDate,
                        Gender = user.Gender
                    };
                    var result = await userManager.CreateAsync(identityUser, user.Password);
                }
            }
            #endregion

            #region Initialize genres
            var genres = await context.Genres.ToListAsync();
            foreach (var genreName in EntityInitialization.Genres)
            {
                if (genres.All(x => x.Name != genreName))
                {
                    var genre = new Genre() { Name = genreName };
                    context.Genres.Add(genre);
                }
            }
            await context.SaveChangesAsync();
            #endregion

            #region Initialize movies

            var movies = await context.Movies
                .Include(m => m.Genres)
                .Include(m => m.Reviews)
                .ToListAsync();

            genres = await context.Genres.ToListAsync();
            foreach (var movieModel in EntityInitialization.Movies)
            {
                bool isMovieExist = true;

                #region Sync moview info
                var movie = movies.FirstOrDefault(x => x.Name != movieModel.Movie.Name);
                if (movie == null)
                {
                    movie = new Movie();
                    isMovieExist = false;
                }
                movie.Name = movieModel.Movie.Name;
                movie.Description = movieModel.Movie.Description;
                movie.Year = movieModel.Movie.Year;
                movie.Country = movieModel.Movie.Country;
                movie.Time = movieModel.Movie.Time;
                movie.Tagline = movieModel.Movie.Tagline;
                movie.Director = movieModel.Movie.Director;
                movie.Budget = movieModel.Movie.Budget;
                movie.Fees = movieModel.Movie.Fees;
                movie.AgeLimit = movieModel.Movie.AgeLimit;
                movie.Rating = movieModel.Movie.Rating;
                movie.PosterLink = movieModel.Movie.PosterLink;

                if (isMovieExist)
                {
                    context.Movies.Update(movie);
                }
                else
                {
                    context.Movies.Add(movie);
                }
                #endregion

                #region Sync movie genres

                movie.Genres ??= new List<Genre>();
                if (movieModel.Genres != null)
                {
                    foreach (var movieGenreName in movieModel.Genres)
                    {
                        var movieGenre = genres.FirstOrDefault(x => x.Name == movieGenreName);
                        if (movieGenre != null && movie.Genres.All(x => x.Name != movieGenreName))
                        {
                            movie.Genres.Add(movieGenre);
                        }

                        if (isMovieExist)
                        {
                            context.Movies.Update(movie);
                        }
                    }

                    try
                    {
                        await context.SaveChangesAsync();
                    }
                    catch (Exception e)
                    {
                        continue;
                    }
                }
                #endregion

                #region Sync movie review

                movie.Reviews ??= new List<Review>();
                var users = await context.Users.ToListAsync();

                if (movieModel.Movie.Reviews != null)
                {
                    foreach (var movieReview in movieModel.Movie.Reviews)
                    {
                        var review = new Review
                        {
                            ReviewText = movieReview.ReviewText,
                            Rating = movieReview.Rating,
                            IsAnonymous = movieReview.IsAnonymous,
                            MovieId = movie.Id,
                        };
                        if (!movieReview.IsAnonymous && movieReview.Author != null)
                        {
                            var author = users.FirstOrDefault(x => x.UserName == movieReview.Author.UserName);
                            if (author == null || movie.Reviews.Any(x => x.AuthorId == author.Id))
                            {
                                continue;
                            }
                            else
                            {
                                review.AuthorId = author.Id;
                            }
                        }
                        else
                        {
                            if (movie.Reviews.Any(x =>
                                x.ReviewText == movieReview.ReviewText && x.Rating == movieReview.Rating &&
                                x.IsAnonymous == movieReview.IsAnonymous))
                            {
                                continue;
                            }
                        }

                        context.Reviews.Add(review);
                    }
                }
                #endregion

            }

            await context.SaveChangesAsync();

            #endregion

        }

    }
}
