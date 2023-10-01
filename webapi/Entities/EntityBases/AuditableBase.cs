using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace webapi.Entities.EntityBases
{
    public class AuditableBase
    {
        public long Id { get; set; }

        public Guid Guid { get; set; }

        public DateTime TimeAdded { get; set; }

        [ForeignKey("UserAdded")]
        public string UserAddedId { get; set; }

        public IdentityUser UserAdded { get; set; }

        public IPAddress IPAdded { get; set; }

        public DateTime TimeModified { get; set; }

        [ForeignKey("UserModified")]
        public string UserModifiedId { get; set; }

        public IdentityUser UserModified { get; set; }

        public IPAddress IPModified { get; set; }

        public bool IsActive { get; set; }

    }
}
