using cognisseum.Entities;

namespace webapi.Services
{
    public class ElementService : DbServiceBase
    {
        public ElementService(CgnContext db) : base(db) { }

        private CgnContext Db { get; set; }
    }
}
