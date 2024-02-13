using System.ComponentModel.DataAnnotations;

namespace Warsztat.Model
{
    internal class Zlecenie
    {
        [Key]
        public int Id { get; set; }
        public int ZleceniodawcaPESEL { get; set; }
        public decimal Oplata { get; set; }
        public List<Pracownik> Pracownicy { get; set; } = new List<Pracownik>();
        public string? DataWykonania { get; set; }
        public bool Zakonczone { get; set; }
        public Zlecenie() { }
        public Zlecenie(int pesel, decimal kwota, string? data)
        {
            ZleceniodawcaPESEL = pesel;
            Oplata = kwota;
            DataWykonania = data;
            Zakonczone = false;
        }
    }
}
