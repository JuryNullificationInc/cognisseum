using cognisseum.Entities;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Entities.DataSeeding
{
    public class SeedModels
    {
        public class SeedElementModel
        {
            public long AtomicNumber { get; set; }

            public string ElementName { get; set; }

            public string Symbol { get; set; }

            public double AtomicWeight { get; set; }

            public long Period { get; set; }

            public long Group { get; set; }

            public Phase Phase { get; set; }

            [AllowNull]
            public string? MostStableCrystal { get; set; }

            public string Type { get; set; }

            [AllowNull]
            public float IonicRadius { get; set; }

            [AllowNull]
            public double AtomicRadius { get; set; }

            [AllowNull]
            public double Electronegativity { get; set; }

            [AllowNull]
            public double FirstIonizationPotential { get; set; }

            [AllowNull]
            public double Density { get; set; }

            [AllowNull]
            public double MeltingPoint { get; set; }

            [AllowNull]
            public double BoilingPoint { get; set; }

            [AllowNull]
            public long Isotopes { get; set; }

            [AllowNull]
            public string Discoverer { get; set; }

            [AllowNull]
            public string YearOfDiscovery { get; set; }

            [AllowNull]
            public float SpecificHeatCapacity { get; set; }

            [AllowNull]
            public string ElectronConfiguration { get; set; }

            public long DisplayRow { get; set; }

            public long DisplayColumn { get; set; }
        }
    }
}
