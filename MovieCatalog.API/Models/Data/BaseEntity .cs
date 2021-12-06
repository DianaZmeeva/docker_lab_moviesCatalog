using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCatalog.API.Models.Data
{
    public interface IBaseEntity
    {
        public Guid Id { get; set; }
    }
    public class BaseEntity : IBaseEntity
    {
        public Guid Id { get; set; }
    }
}
