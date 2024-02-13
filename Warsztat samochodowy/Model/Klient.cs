using System.ComponentModel.DataAnnotations;

namespace Warsztat.Model
{
    internal class Klient
    {
        [Key]
        public int Id { get; set; }
        public int PESEL { get; set; }
        public string? Imie { get; set; }
        public string? Nazwisko { get; set; }
        public int Telefon { get; set; }
        public Klient() { }

        public Klient(int pesel, string imie, string nazwisko, int telefon)
        {
            PESEL = pesel;
            Imie = imie;
            Nazwisko = nazwisko;
            Telefon = telefon;
        }
    }
}
