using System.Drawing;
using webapi.DTOs.DtoBases;

namespace webapi.DTOs
{
    public class ElementPhaseDto : DtoBaseWithImage
    { 
        public string PhaseName { get; set; }

        public string PhaseAcronym { get; set; }
    }
}
