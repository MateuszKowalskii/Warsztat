using System.ComponentModel.DataAnnotations;

namespace Warsztat_samochodowy.Rekordy
{
    internal class Zlecenie
    {
        [Key]
        public int Id { get; set; }
        public int zleceniodawcaPESEL { get; set; }
        public decimal oplata { get; set; }
        public List<Pracownik> pracownicy { get; set; } = new List<Pracownik>();
        public string? dataWykonania { get; set; }
        public bool zakonczone { get; set; }
        public Zlecenie() { }
        public Zlecenie(int pesel,decimal kwota, string? data)
        {
            this.zleceniodawcaPESEL = pesel;
            this.oplata = kwota;
            this.dataWykonania = data;
            this.zakonczone = false;
        }
    }
}
