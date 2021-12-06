using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieCatalog.API.Data;

namespace MovieCatalog.API.Controllers
{
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        protected ApplicationDbContext Context;
        public BaseApiController(ApplicationDbContext context)
        {
            Context = context;
        }
    }
}
