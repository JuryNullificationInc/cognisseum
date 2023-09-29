using cognisseum.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Entities
{
    public class ElementMostStableCrystalConfig : ElementLinkModel
    {
        [ForeignKey("MostStableCrystalConfiguration")]
        public long CrystalConfigId { get; set; }

        public CrystalStructure MostStableCrystalConfiguration { get; set; }
    }
}
