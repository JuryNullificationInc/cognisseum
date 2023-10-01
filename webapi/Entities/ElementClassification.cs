using cognisseum.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using webapi.Entities.EntityBases;

namespace webapi.Entities
{
    public class ElementClassification : ElementLinkBase
    {
        [ForeignKey("Type")]
        public long TypeId { get; set; }

        public ElementType Type { get; set; }
    }
}
