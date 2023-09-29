using System.Diagnostics.CodeAnalysis;

namespace cognisseum.Entities
{
    public class Chemist : AuditableBase
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
