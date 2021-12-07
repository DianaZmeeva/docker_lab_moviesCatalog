using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCatalog.API.Models.Data
{
    public class Review : BaseEntity
    {
        [Required] 
        public string ReviewText { get; set; }
        public int Rating { get; set; }
        public bool IsAnonymous { get; set; }
        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }
        public Guid? AuthorId { get; set; }
        public User Author { get; set; }
    }
}
