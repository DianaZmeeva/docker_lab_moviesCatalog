using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieCatalog.API.Data;

namespace MovieCatalog.API.Controllers
{
    public class HealthController : BaseApiController
    {
        public HealthController(ApplicationDbContext context) : base(context)
        {
        }
        [HttpGet("/health")]
        //[Route("/health")]
        public IActionResult Index()
        {
            return Ok("Healthy");
        }

    }
}
