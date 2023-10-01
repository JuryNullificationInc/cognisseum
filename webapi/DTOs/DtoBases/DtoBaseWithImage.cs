using System.Diagnostics.CodeAnalysis;

namespace webapi.DTOs.DtoBases
{
    public class DtoBaseWithImage
    {
        [AllowNull]
        public string? ImagePath { get; set; }
    }
}
