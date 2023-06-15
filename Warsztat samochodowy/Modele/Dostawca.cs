using System.ComponentModel.DataAnnotations;

namespace Warsztat_samochodowy.Modele
{
    internal class Dostawca
    {
        [Key]
        public int Id { get; set; }
        public string? nazwa { get; set; }
        public string? email { get; set; }
        public int telefon { get; set; }
        public Dostawca() { }

        public Dostawca(string nazwa, string email, int telefon)
        {
            this.nazwa = nazwa;
            this.email = email;
            this.telefon = telefon;

        }

    }
}
