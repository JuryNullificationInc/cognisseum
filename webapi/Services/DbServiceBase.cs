using cognisseum.Entities;
using webapi.DTOs;

namespace webapi.Services
{
    public class DbServiceBase
    {
        public DbServiceBase(CgnContext db) => Db = db;

        public ElementDto? GetElementBySymbol(string symbol)
            => ElementToDto(Db.Elements.AsQueryable().Where(x => x.Symbol == symbol).SingleOrDefault());

        public ElementDto? GetElementByAtomicNumber(long num)
            => ElementToDto(Db.Elements.AsQueryable().Where(x => x.AtomicNumber == num).SingleOrDefault());

        public ElementDto? ElementToDto(Element? element)
            => element is null ? null : new()
            {
                AtomicNumber = element.AtomicNumber,
                ElementName = element.ElementName,
                Symbol = element.Symbol,
                AtomicWeight = element.AtomicWeight,
                Period = element.Period,
                Group = element.Group,
                IonicRadius = element.IonicRadius,
                AtomicRadius = element.AtomicRadius,
                Electronegativity = element.Electronegativity,
                FirstIonizationPotential = element.FirstIonizationPotential,
                Density = element.Density,
                MeltingPoint = element.MeltingPoint,
                BoilingPoint = element.BoilingPoint,
                Isotopes = element.Isotopes,
                SpecificHeatCapacity = element.SpecificHeatCapacity,
                ElectronConfiguration = element.ElectronConfiguration,
                DisplayRow = element.DisplayRow,
                DisplayColumn = element.DisplayColumn,
            };

        private CgnContext Db { get; set; }
    }
}
