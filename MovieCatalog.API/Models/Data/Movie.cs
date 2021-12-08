using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCatalog.API.Models.Data
{
    public class Movie : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public int Time { get; set; }
        public string Tagline { get; set; }
        public string Director { get; set; }
        public int? Budget { get; set; }
        public int? Fees { get; set; }
        public int AgeLimit { get; set; }
        public string PosterLink { get; set; }
        public ICollection<Genre> Genres { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
