using cognisseum.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using webapi.Entities.EntityBases;

namespace webapi.Entities.Entities
{
    public class ElementDiscovery : ElementLinkBase
    {
        public ElementDiscoveryGroup Discoverers { get; set; }

        [ForeignKey("Discoverers")]
        public long DiscoverersId { get; set; }

        [AllowNull]
        public string? Biography { get; set; }
    }
}
