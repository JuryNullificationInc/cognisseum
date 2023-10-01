using System.Diagnostics.CodeAnalysis;

namespace webapi.DTOs.DtoBases
{
    public class DtoBaseWithImageAndColor : DtoBaseWithImage
    {
        [AllowNull]
        public string? Color { get; set; }
    }
}
