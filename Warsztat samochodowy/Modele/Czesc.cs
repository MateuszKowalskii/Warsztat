using System.ComponentModel.DataAnnotations;

namespace Warsztat_samochodowy.Modele
{
    internal class Czesc
    {
        [Key]
        public int Id { get; set; }
        public string? producent { get; set; }
        public string? kod { get; set; }
        public string? nazwa { get; set; }
        public int ilosc { get; set; }
        public Czesc() { }

        public Czesc(string producent, string kod, string nazwa, int ilosc)
        {
            this.producent = producent;
            this.kod = kod;
            this.nazwa = nazwa;
            this.ilosc = ilosc;

        }

    }
}
