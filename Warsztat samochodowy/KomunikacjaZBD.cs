using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warsztat_samochodowy.Rekordy;

namespace Warsztat_samochodowy
{
    internal class KomunikacjaZBD: DbContext
    {
        public DbSet<Rekordy.Klient> klienci { get; set; }
        public DbSet<Rekordy.Pracownik> pracownicy { get; set; }
        public DbSet<Rekordy.Dostawca> dostawcy { get; set; }
        public DbSet<Rekordy.Czesc> czesci { get; set; }
        public DbSet<Rekordy.Zamowienie> zamowienia { get; set; }
        public DbSet<Rekordy.Zlecenie> zlecenia { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rekordy.Klient>(k =>
            {
                k.Property(x => x.PESEL).IsRequired();
                k.HasIndex(x => x.PESEL).IsUnique();
            });
            modelBuilder.Entity<Rekordy.Pracownik>(p =>
            {
                p.Property(x => x.PESEL).IsRequired();
                p.HasIndex(x => x.PESEL).IsUnique();
            });
            modelBuilder.Entity<Rekordy.Dostawca>(d =>
            {
                d.Property(x => x.nazwa).IsRequired();
                d.HasIndex(x => x.nazwa).IsUnique();
            });
            modelBuilder.Entity<Rekordy.Czesc>(c =>
            {
                c.Property(x => x.kod).IsRequired();
                c.HasIndex(x => x.kod).IsUnique();
            });
            modelBuilder.Entity<Rekordy.Zamowienie>(z =>
            {
                z.Property(x => x.kiedyDotrze).IsRequired();
            });
            modelBuilder.Entity<Rekordy.Zlecenie>()
                .HasMany(z => z.pracownicy)
                .WithMany(p=> p.zlecenia);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WarsztatSamochodowy;Trusted_Connection=True;");
        }
    }
}
