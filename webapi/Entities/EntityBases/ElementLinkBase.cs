using System.ComponentModel.DataAnnotations.Schema;
using webapi.Entities.Entities;

namespace webapi.Entities.EntityBases
{
    public class ElementLinkBase : AuditableBase
    {
        [ForeignKey("Element")]
        public long ElementId { get; set; }

        public Element Element { get; set; }
    }
}
