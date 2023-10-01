using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using webapi.Entities.EntityBases;

namespace webapi.Entities.Entities
{
    public class Element : AuditableBase
    {
        public long AtomicNumber { get; set; }

        public string ElementName { get; set; }

        public string Symbol { get; set; }

        public double AtomicWeight { get; set; }

        public long Period { get; set; }

        public long Group { get; set; }

        [ForeignKey("STPPhase")]
        public long PhaseId { get; set; }

        public Phase STPPhase { get; set; }

        [ForeignKey("CrystalConfig")]
        public long ConfigId { get; set; }

        public CrystalStructure CrystalConfig { get; set; }

        [AllowNull]
        public float? IonicRadius { get; set; }

        [AllowNull]
        public double? AtomicRadius { get; set; }

        [AllowNull]
        public double? Electronegativity { get; set; }

        [AllowNull]
        public double? FirstIonizationPotential { get; set; }

        [AllowNull]
        public double? Density { get; set; }

        [AllowNull]
        public double? MeltingPoint { get; set; }

        [AllowNull]
        public double? BoilingPoint { get; set; }

        [AllowNull]
        public long? Isotopes { get; set; }

        [AllowNull]
        public float? SpecificHeatCapacity { get; set; }

        [AllowNull]
        public string? ElectronConfiguration { get; set; }

        public long DisplayRow { get; set; }

        public long DisplayColumn { get; set; }
    }
}
