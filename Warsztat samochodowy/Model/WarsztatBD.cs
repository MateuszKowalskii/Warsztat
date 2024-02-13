using Microsoft.EntityFrameworkCore;
using Warsztat.Model;

namespace Warsztat
{
    internal class WarsztatBD : DbContext
    {
        public DbSet<Klient> Klienci { get; set; }
        public DbSet<Pracownik> Pracownicy { get; set; }
        public DbSet<Dostawca> Dostawcy { get; set; }
        public DbSet<Czesc> Czesci { get; set; }
        public DbSet<Zamowienie> Zamowienia { get; set; }
        public DbSet<Zlecenie> Zlecenia { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Klient>(k =>
            {
                k.Property(x => x.PESEL).IsRequired();
                k.HasIndex(x => x.PESEL).IsUnique();
            });
            modelBuilder.Entity<Pracownik>(p =>
            {
                p.Property(x => x.PESEL).IsRequired();
                p.HasIndex(x => x.PESEL).IsUnique();
            });
            modelBuilder.Entity<Dostawca>(d =>
            {
                d.Property(x => x.Nazwa).IsRequired();
                d.HasIndex(x => x.Nazwa).IsUnique();
            });
            modelBuilder.Entity<Czesc>(c =>
            {
                c.Property(x => x.Kod).IsRequired();
                c.HasIndex(x => x.Kod).IsUnique();
            });
            modelBuilder.Entity<Zamowienie>(z =>
            {
                z.Property(x => x.KiedyDotrze).IsRequired();
            });
            modelBuilder.Entity<Zlecenie>(z =>
            {
                z.HasMany(a => a.Pracownicy)
                .WithMany(b => b.Zlecenia);
                z.Property(c => c.Oplata)
                .HasColumnType("decimal(18,2)");
            });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string polaczenie = "Server=(localdb)\\mssqllocaldb;Database=WarsztatSamochodowy;Trusted_Connection=True;";
            optionsBuilder
                .UseSqlServer(polaczenie);
        }
    }
}
