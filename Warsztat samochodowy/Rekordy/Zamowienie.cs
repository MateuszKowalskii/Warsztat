using System.ComponentModel.DataAnnotations;

namespace Warsztat_samochodowy.Rekordy
{
    internal class Zamowienie
    {
        [Key]
        public int Id { get; set; }
        public string? dostawcaNazwa { get; set; }
        public string? kod { get; set; }
        public string? nazwa { get; set; }
        public int ilosc { get; set; }
        public string? kiedyDotrze { get; set; }
        public Zamowienie() { }

        public Zamowienie(string dostawca, string kod, string nazwa, int ilosc, string data)
        {
            this.dostawcaNazwa = dostawca;
            this.kod = kod;
            this.nazwa = nazwa;
            this.ilosc = ilosc;
            this.kiedyDotrze = data;

        }

    }
}
