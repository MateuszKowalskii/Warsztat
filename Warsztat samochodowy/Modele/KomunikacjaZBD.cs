using Microsoft.EntityFrameworkCore;
using Warsztat_samochodowy.Modele;

namespace Warsztat_samochodowy
{
    internal class KomunikacjaZBD : DbContext
    {
        public DbSet<Klient> klienci { get; set; }
        public DbSet<Pracownik> pracownicy { get; set; }
        public DbSet<Dostawca> dostawcy { get; set; }
        public DbSet<Czesc> czesci { get; set; }
        public DbSet<Zamowienie> zamowienia { get; set; }
        public DbSet<Zlecenie> zlecenia { get; set; }

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
                d.Property(x => x.nazwa).IsRequired();
                d.HasIndex(x => x.nazwa).IsUnique();
            });
            modelBuilder.Entity<Czesc>(c =>
            {
                c.Property(x => x.kod).IsRequired();
                c.HasIndex(x => x.kod).IsUnique();
            });
            modelBuilder.Entity<Zamowienie>(z =>
            {
                z.Property(x => x.kiedyDotrze).IsRequired();
            });
            modelBuilder.Entity<Zlecenie>()
                .HasMany(z => z.pracownicy)
                .WithMany(p => p.zlecenia);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string polaczenie = "Server=(localdb)\\mssqllocaldb;Database=WarsztatSamochodowy;Trusted_Connection=True;";
            optionsBuilder
                .UseSqlServer(polaczenie);
        }

    }
}
