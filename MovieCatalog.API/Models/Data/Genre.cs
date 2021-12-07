using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCatalog.API.Models.Data
{
    public class Genre :BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
