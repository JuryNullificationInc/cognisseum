using Microsoft.EntityFrameworkCore;
using webapi.Entities;
using webapi.Entities.DataSeeding;

namespace cognisseum.Entities
{
    public class CgnContext : DbContext
    {
        public CgnContext(DbContextOptions<CgnContext> options) : base(options)
            { 
            }

        public DbSet<Element> Elements { get; set; }

        public DbSet<Phase> Phases { get; set; }

        public DbSet<Chemist> Chemists { get; set; }

        public DbSet<CrystalStructure> CrystalStructures { get; set; }

        public DbSet<ElementDiscovery> ElementDiscoveries { get; set; }

        public DbSet<ElementType> ElementTypes { get; set; }

        public DbSet<ElementDiscoveryGroup> ElementDiscoveryGroups { get; set; }

        public DbSet<ElementClassification> ElementClassifications { get; set; }

        public DbSet<ElementSTPPhase> ElementSTPPhases { get; set; }

        public DbSet<ElementMostStableCrystalConfig> ElementStableCrystalConfigs { get; set; }

        public void RestrictUserModified<T>(ModelBuilder builder) where T : AuditableBase
            => builder.Entity<T>()
                .HasOne(e => e.UserModified)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

        public void RestrictUserAdded<T>(ModelBuilder builder) where T : AuditableBase
            => builder.Entity<T>()
                .HasOne(e => e.UserAdded)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

        public void AddEntityTable<T>(ModelBuilder builder, string name) where T : AuditableBase
            => builder.Entity<T>().ToTable(name);

        public void AddEntity<T>(ModelBuilder builder, string name) where T : AuditableBase
        {
            RestrictUserModified<T>(builder);
            RestrictUserAdded<T>(builder);
            AddEntityTable<T>(builder, name);
        }

        public void RestrictElement<T>(ModelBuilder builder) where T : ElementLinkModel
            => builder.Entity<T>()
            .HasOne(e => e.Element)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AddEntity<Element>(modelBuilder, "Element");
            AddEntity<Phase>(modelBuilder, "Phase");
            AddEntity<Chemist>(modelBuilder, "Chemist");
            AddEntity<CrystalStructure>(modelBuilder, "CrystalStructure");
            AddEntity<ElementDiscovery>(modelBuilder, "ElementDiscovery");
            AddEntity<ElementDiscoveryGroup>(modelBuilder, "ElementDiscoveryGroup");
            AddEntity<ElementType>(modelBuilder, "ElementType");
            AddEntity<ElementClassification>(modelBuilder, "ElementClassification");
            AddEntity<ElementMostStableCrystalConfig>(modelBuilder, "ElementMostStableCrystalConfig");
            AddEntity<ElementSTPPhase>(modelBuilder, "ElementSTPPhase");

            RestrictElement<ElementClassification>(modelBuilder);
            RestrictElement<ElementMostStableCrystalConfig>(modelBuilder);
            RestrictElement<ElementSTPPhase>(modelBuilder);

            var seeder = new DataSeeder(modelBuilder);

            seeder.Seed();
        }
    }
}
