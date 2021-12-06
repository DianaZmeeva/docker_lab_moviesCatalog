using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCatalog.API.Models.Api.Auth
{
    public class LoginCredentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
