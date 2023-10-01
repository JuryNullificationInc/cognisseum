using cognisseum.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Entities.EntityBases
{
    public class ElementLinkBase : AuditableBase
    {
        [ForeignKey("Element")]
        public long ElementId { get; set; }

        public Element Element { get; set; }
    }
}
