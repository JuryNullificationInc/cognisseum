using System.Drawing;
using webapi.DTOs.DtoBases;

namespace webapi.DTOs
{
    public class ElementCrystalConfigDto : DtoBaseWithImage
    {
        public string Name { get; set; }

        public string Acronym { get; set; }
    }
}
