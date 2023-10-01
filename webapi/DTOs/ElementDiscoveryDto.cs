using System.Drawing;

namespace webapi.DTOs
{
    public class ElementDiscoveryDto
    {
        public string DiscoveryGroupName { get; set; }

        public string YearOfDiscovery { get; set; }

        public string DiscovererBio { get; set; }

        public Color Color { get; set; }

        public string PicturePath { get; set; }
    }
}
