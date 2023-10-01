using cognisseum.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using webapi.DTOs;
using webapi.Entities.Entities;

namespace webapi.Services
{
    public class ElementService : DbServiceBase
    {
        public ElementService(CgnContext db) : base(db) { }

        private IEnumerable<long> GetClassificationsByElement(Element e)
            => Db.ElementClassifications.AsQueryable().Where(x => x.ElementId == e.Id).Select(x => x.TypeId).ToList();

/*        private List<ClassificationDto> GetClassificationDtosByElement(Element e)
            => 

        private ElementExtraDto ElementToExtraDto(Element e)
        {
            if (e == null)
            {

            }
        }*/

        private IEnumerable<Element> GetElementsByPred(Func<Element, bool> pred)
            => Db.Elements.AsQueryable().Where(x => pred(x));

/*        public ElementExtraDto GetElementExtraById(long id)
            => ElementToExtraDto(GetElementsByPred(x => x.Id == id).SingleOrDefault());
*/
        private CgnContext Db { get; set; }
    }
}
