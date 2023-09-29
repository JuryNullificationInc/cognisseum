using cognisseum.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Entities
{
    public class ElementDiscovery : ElementLinkModel
    {
        public ElementDiscoveryGroup Discoverers { get; set; }

        [ForeignKey("Discoverers")]
        public long DiscoverersId { get; set; }

        [AllowNull]
        public string? Biography { get; set; }
    }
}
