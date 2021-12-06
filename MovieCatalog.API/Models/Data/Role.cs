using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MovieCatalog.API.Models.Data
{
    public class Role : IdentityRole<Guid>, IBaseEntity
    {
    }
}
