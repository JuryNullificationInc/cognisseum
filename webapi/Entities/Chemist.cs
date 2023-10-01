using System.Diagnostics.CodeAnalysis;
using webapi.Entities.EntityBases;

namespace cognisseum.Entities
{
    public class Chemist : BaseWithImage
    {
        [AllowNull]
        public string FirstName { get; set; }

        [AllowNull]
        public string MiddleName { get; set; }

        [AllowNull]
        public string LastName { get; set; }

        [AllowNull]
        public DateTime BirthDate { get; set; }

        [AllowNull]
        public DateTime ExpiryDate { get; set; }
    }
}
