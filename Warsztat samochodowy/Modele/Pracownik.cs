using System.ComponentModel.DataAnnotations;

namespace Warsztat_samochodowy.Modele
{
    internal class Pracownik
    {
        [Key]
        public int Id { get; set; }
        public int PESEL { get; set; }
        public string? imie { get; set; }
        public string? nazwisko { get; set; }
        public int telefon { get; set; }
        public string? rola { get; set; }
        public List<Zlecenie> zlecenia { get; set; } = new List<Zlecenie>();
        public Pracownik() { }

        public Pracownik(int pesel, string imie, string nazwisko, int telefon, string rola)
        {
            PESEL = pesel;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.telefon = telefon;
            this.rola = rola;

        }

    }
}