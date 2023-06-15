using System.ComponentModel.DataAnnotations;

namespace Warsztat_samochodowy.Modele
{
    internal class Klient
    {
        [Key]
        public int Id { get; set; }
        public int PESEL { get; set; }
        public string? imie { get; set; }
        public string? nazwisko { get; set; }
        public int telefon { get; set; }
        public Klient() { }

        public Klient(int pesel, string imie, string nazwisko, int telefon)
        {
            PESEL = pesel;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.telefon = telefon;

        }

    }
}
