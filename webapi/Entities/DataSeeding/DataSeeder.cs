using cognisseum.Entities;
using CsvHelper;
using MathNet.Numerics.LinearAlgebra;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;

namespace webapi.Entities.DataSeeding
{
    public class DataSeeder
    {

        public DataSeeder(ModelBuilder modelBuilder) => Builder = modelBuilder;

        private ModelBuilder Builder { get; set;  }

        private readonly IPAddress localAddr = IPAddress.Loopback;

        public T AddIPStuff<T>(T x) where T : AuditableBase
        {
            x.IPAdded = localAddr;
            x.IPModified = localAddr;
            return x;
        }

        public List<T>? GetModels<T>(string filename) where T : AuditableBase
        {
            var str = new StreamReader(filename).ReadToEnd();
            var jArr = JArray.Parse(str);
            var newArr = jArr.ToList().ConvertAll(x => AddIPStuff<T>(x.ToObject<T>()));
            return newArr;
        }

        public void Seed()
        {
            SeedUser();
            SeedPhases();
            SeedCrystalStructures();
            SeedTypes();
            SeedElements();
            SeedDiscoveryGroups();
            SeedDiscoveries();
            SeedEPhases();
            SeedETypes();
            SeedECrystals();
        }

        private void SeedECrystals()
            => SeedThings<ElementMostStableCrystalConfig>("./Entities/DataSeeding/json_data/e_crystals.json");

        private void SeedETypes()
            => SeedThings<ElementSTPPhase>("./Entities/DataSeeding/json_data/e_phases.json");

        private void SeedEPhases()
            => SeedThings<ElementClassification>("./Entities/DataSeeding/json_data/e_types.json");

        public void SeedUser()
        {
            Builder.Entity<IdentityUser>().HasData(
                new
                {
                    Id = "1",
                    UserName = "CognitarExNihilo",
                    NormalizedUserName = "COGNITAREXNIHILO",
                    Email = string.Empty,
                    NormalizedEmail = string.Empty,
                    EmailConfirmed = true,
                    PasswordHash = string.Empty,
                    SecurityStamp = "51433c62-7a19-44a4-b0e4-ce1d0383a585",
                    ConcurrencyStamp = "a44e371a-6840-4cef-80a2-e113068694d1",
                    PhoneNumber = string.Empty,
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = false,
                    LockoutEnabled = true,
                    AccessFailedCount = int.MaxValue,
                }
                );
        }

        public void SeedThings<T>(string fn) where T : AuditableBase
            => Builder.Entity<T>().HasData(GetModels<T>(fn));

        public void SeedCrystalStructures()
            => SeedThings<CrystalStructure>("./Entities/DataSeeding/json_data/crystals.json");

        public void SeedElements()
            => SeedThings<Element>("./Entities/DataSeeding/json_data/table.json");

        public void SeedPhases()
            => SeedThings<Phase>("./Entities/DataSeeding/json_data/phases.json");

        public void SeedTypes()
            => SeedThings<ElementType>("./Entities/DataSeeding/json_data/types.json");

        public void SeedDiscoveryGroups()
            => SeedThings<ElementDiscoveryGroup>("./Entities/DataSeeding/json_data/disc_profs.json");

        public void SeedDiscoveries()
            => SeedThings<ElementDiscovery>("./Entities/DataSeeding/json_data/discoveries.json");
    }
}
