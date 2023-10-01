using webapi.Entities.EntityBases;

namespace webapi.Entities.Entities
{
    public class Phase : BaseWithImage
    {
        public string Name { get; set; }

        public string Acronym { get; set; }
    }
}
