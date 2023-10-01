using System.Diagnostics.CodeAnalysis;

namespace webapi.Entities.EntityBases
{
    public class BaseWithImage : AuditableBase
    {
        [AllowNull]
        public string? ImagePath { get; set; }
    }
}
