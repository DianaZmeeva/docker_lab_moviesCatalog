using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MovieCatalog.API.Models.Data
{
    public class User : IdentityUser<Guid>, IBaseEntity
    {
        [Required]
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string Avatar { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public DateTime? DeleteDate { get; set; }

        public ICollection<Movie> FavoriteMovies { get; set; }
    }

    public enum Gender
    {
        Male = 0,
        Female = 1
    }
}
