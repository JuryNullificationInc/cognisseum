using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Entities.EntityBases
{
    public class BaseWithImageAndColor : BaseWithImage
    {
        [AllowNull]
        [ForeignKey("Color")]
        public long ColorId { get; set; }

        [AllowNull]
        public WebColor Color { get; set; }
    }
}
