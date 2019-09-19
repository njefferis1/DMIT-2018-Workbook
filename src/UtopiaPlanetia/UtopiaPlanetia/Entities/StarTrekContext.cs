namespace UtopiaPlanetia.DAL // changed the namespace for context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using UtopiaPlanetia.Entities; // for entity classes

    public partial class StarTrekContext : DbContext
    {
        public StarTrekContext()
            : base("name=STdb")
        {
        }

        public virtual DbSet<Ship> Ships { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ship>()
                .Property(e => e.RegistryNumber)
                .IsFixedLength();
        }
    }
}
