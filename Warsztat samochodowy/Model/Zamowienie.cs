using System.ComponentModel.DataAnnotations;

namespace Warsztat.Model
{
    internal class Zamowienie
    {
        [Key]
        public int Id { get; set; }
        public string? DostawcaNazwa { get; set; }
        public string? Kod { get; set; }
        public string? Nazwa { get; set; }
        public int Ilosc { get; set; }
        public string? KiedyDotrze { get; set; }
        public Zamowienie() { }

        public Zamowienie(string dostawca, string kod, string nazwa, int ilosc, string data)
        {
            DostawcaNazwa = dostawca;
            Kod = kod;
            Nazwa = nazwa;
            Ilosc = ilosc;
            KiedyDotrze = data;
        }
    }
}
