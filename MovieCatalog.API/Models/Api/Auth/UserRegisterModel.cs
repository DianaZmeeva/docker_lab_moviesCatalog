using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MovieCatalog.API.Models.Data;

namespace MovieCatalog.API.Models.Api.Auth
{
    public class UserRegisterModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
    }
}
