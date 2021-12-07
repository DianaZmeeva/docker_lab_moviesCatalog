using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCatalog.API.Models.Api.Users
{
    public class UserShortModel
    {
        public Guid UserId { get; set; }
        public string NickName { get; set; }
    }
}
