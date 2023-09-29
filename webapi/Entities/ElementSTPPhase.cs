using cognisseum.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Entities
{
    public class ElementSTPPhase : ElementLinkModel
    {
        [ForeignKey("STPPhase")]
        public long PhaseId { get; set; }

        public Phase STPPhase { get; set; }
    }
}
