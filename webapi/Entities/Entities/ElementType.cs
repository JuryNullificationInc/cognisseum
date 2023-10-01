using System.ComponentModel.DataAnnotations.Schema;
using webapi.Entities;
using webapi.Entities.EntityBases;

namespace webapi.Entities.Entities
{
    public class ElementType : BaseWithImageAndColor
    {
        public string Name { get; set; }

        public string Acronym { get; set; }
    }
}
