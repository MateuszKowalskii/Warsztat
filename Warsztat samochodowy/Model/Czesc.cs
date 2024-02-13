using System.ComponentModel.DataAnnotations;

namespace Warsztat.Model
{
    internal class Czesc
    {
        [Key]
        public int Id { get; set; }
        public string? Producent { get; set; }
        public string? Kod { get; set; }
        public string? Nazwa { get; set; }
        public int Ilosc { get; set; }
        public Czesc() { }

        public Czesc(string producent, string kod, string nazwa, int ilosc)
        {
            Producent = producent;
            Kod = kod;
            Nazwa = nazwa;
            Ilosc = ilosc;
        }
    }
}
