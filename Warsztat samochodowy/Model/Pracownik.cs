using System.ComponentModel.DataAnnotations;

namespace Warsztat.Model
{
    internal class Pracownik
    {
        [Key]
        public int Id { get; set; }
        public int PESEL { get; set; }
        public string? Imie { get; set; }
        public string? Nazwisko { get; set; }
        public int Telefon { get; set; }
        public string? Rola { get; set; }
        public List<Zlecenie> Zlecenia { get; set; } = new List<Zlecenie>();
        public Pracownik() { }

        public Pracownik(int pesel, string imie, string nazwisko, int telefon, string rola)
        {
            PESEL = pesel;
            Imie = imie;
            Nazwisko = nazwisko;
            Telefon = telefon;
            Rola = rola;
        }
    }
}