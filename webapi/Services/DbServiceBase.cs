using cognisseum.Entities;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using webapi.DTOs;
using webapi.Entities.Entities;
using webapi.Exceptions;

namespace webapi.Services
{
    public class DbServiceBase
    {
        public DbServiceBase(CgnContext db) => Db = db;

        private void ThrowNullArgumentException(string funcName, string funcArg)
            => throw new NullArgumentException("DbServiceBase", funcName, funcArg);

        public ElementDto GetElementDtoBySymbol(string symbol)
            => ElementToDto(Db.Elements.AsQueryable().Where(x => x.Symbol == symbol).SingleOrDefault() ?? throw new DbLookupException("Element", "Symbol", symbol));

        public ElementDto GetElementDtoByAtomicNumber(long num)
            => ElementToDto(Db.Elements.AsQueryable().Where(x => x.AtomicNumber == num).SingleOrDefault() ?? throw new IdLookupException("Element", num));

        public ElementPhaseDto PhaseToDto(Phase phase)
            => new()
            {
                Name = phase.Name,
                Acronym = phase.Acronym,
                ImagePath = phase.ImagePath,
            };

        private Phase GetPhaseById(long id)
            => Db.Phases.AsQueryable().Where(x => x.Id == id).SingleOrDefault()
                ?? throw new IdLookupException("Phase", id);

        public ElementPhaseDto GetPhaseDtoById(long id)
            => PhaseToDto(GetPhaseById(id));

        private CrystalStructure GetCrystalById(long id)
            => Db.CrystalStructures.AsQueryable().Where(x => x.Id == id).SingleOrDefault()
                ?? throw new IdLookupException("CrystalStructure", id);

        public ElementCrystalConfigDto CrystalStructureToDto(CrystalStructure xtal)
            => new()
            {
                Name = xtal.Name,
                Acronym = xtal.Acronym,
                ImagePath = xtal.ImagePath,
            };

        public ElementCrystalConfigDto GetCrystalConfigDtoById(long id)
            => CrystalStructureToDto(GetCrystalById(id));

        private IEnumerable<ElementClassification> GetClassificationsByElementId(long id)
            => Db.ElementClassifications.AsQueryable().Where(x => x.ElementId == id);

        private ElementType ElementTypeById(long id)
            => Db.ElementTypes.AsQueryable().Where(x => x.Id == id).SingleOrDefault()
                ?? throw new IdLookupException("ElementType", id);

        private IEnumerable<ElementType> GetTypesByElementId(long id)
            => GetClassificationsByElementId(id).ToList().ConvertAll(x => ElementTypeById(x.TypeId)).AsEnumerable();

        private string GetColorCodeByColorId(long id)
            => Db.Colors.AsQueryable().Where(x => x.Id == id).SingleOrDefault()?.Code ??
                throw new IdLookupException("WebColor", id);

        public ElementTypeDto ElementTypeToDto(ElementType tp)
            => new()
            {
                Name = tp.Name,
                Acronym = tp.Acronym,
                ImagePath = tp.ImagePath,
                Color = GetColorCodeByColorId(tp.ColorId),
            };

        private IEnumerable<ElementTypeDto> GetTypeDtosByElementId(long id)
            => GetTypesByElementId(id).ToList().ConvertAll(ElementTypeToDto).AsEnumerable();

        public ElementDto ElementToDto(Element? element)
            => new()
            {
                AtomicNumber = element.AtomicNumber,
                ElementName = element.ElementName,
                Symbol = element.Symbol,
                AtomicWeight = element.AtomicWeight,
                Phase = GetPhaseDtoById(element.PhaseId),
                CrystalConfig = GetCrystalConfigDtoById(element.ConfigId),
                Classifications = GetTypeDtosByElementId(element.Id),
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
