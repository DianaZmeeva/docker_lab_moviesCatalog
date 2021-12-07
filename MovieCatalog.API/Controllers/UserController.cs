using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MovieCatalog.API.Data;
using MovieCatalog.API.Models.Api.User;
using MovieCatalog.API.Models.Data;

namespace MovieCatalog.API.Controllers
{
    [Authorize]
    [Route("api/users")]
    public class UserController : BaseApiController
    {
        public UserController(ApplicationDbContext context, 
            UserManager<User> userManager) : base(context, userManager)
        {
        }

        [HttpGet("/api/account/profile")]
        public async Task<ActionResult<ProfileModel>> GetProfile()
        {
            var user = await UserManager.FindByNameAsync(User.Identity.Name);

            if (user == null)
            {
                return NotFound();
            }

            return new ProfileModel
            {
                NickName = user.UserName,
                Email = user.Email,
                AvatarLink = user.Avatar,
                Name = user.Name,
                BirthDate = user.BirthDate,
                Gender = user.Gender
            };
        }

        [HttpPut("/api/account/profile")]
        public async Task<IActionResult> PutPost(ProfileModel model)
        {
            var user = await UserManager.FindByNameAsync(User.Identity.Name);

            if (user == null)
            {
                return NotFound();
            }

            #region Check model
            if (!ModelState.IsValid)
            {
                return new BadRequestObjectResult(new { Message = "Can't update user profile", Errors = ModelState });
            }

            if (model.BirthDate >= DateTime.Now)
            {
                return new BadRequestObjectResult(new { Message = "Invalid birth date" });
            }

            var userWithSameEmail = await Context.Users.Where(x => x.Id != user.Id && x.Email == model.Email).FirstOrDefaultAsync();
            if (userWithSameEmail != null)
            {
                return new BadRequestObjectResult(new { Message = "User with such email has already exist" });
            }
            #endregion

            user.Email = model.Email;
            user.Avatar = model.AvatarLink;
            user.Name = model.Name;
            user.BirthDate = model.BirthDate;
            user.Gender = model.Gender;

            Context.Users.Update(user);
            await Context.SaveChangesAsync();

            return StatusCode(200);

        }



    }

}
