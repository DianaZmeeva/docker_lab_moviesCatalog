using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCatalog.API.Models.Api.Reviews
{
    public class ReviewModifyModel
    {
        [Required]
        public string ReviewText { get; set; }
        [Range(0,10)]
        public int Rating { get; set; }
        public bool IsAnonymous { get; set; }
    }
}
