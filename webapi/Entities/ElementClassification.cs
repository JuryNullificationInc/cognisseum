using cognisseum.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Entities
{
    public class ElementClassification : ElementLinkModel
    {
        [ForeignKey("Type")]
        public long TypeId { get; set; }

        public ElementType Type { get; set; }
    }
}
