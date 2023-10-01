using System.Drawing;
using webapi.DTOs.DtoBases;

namespace webapi.DTOs
{
    public class ElementDiscoveryDto : DtoBaseWithImage
    {
        public string DiscoveryGroupName { get; set; }

        public string YearOfDiscovery { get; set; }

        public string DiscovererBio { get; set; }
    }
}
