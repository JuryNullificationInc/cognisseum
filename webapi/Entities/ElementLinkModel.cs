using cognisseum.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Entities
{
    public class ElementLinkModel : AuditableBase
    {
        [ForeignKey("Element")]
        public long ElementId { get; set; }

        public Element Element { get; set; }
    }
}
