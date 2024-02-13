using System.ComponentModel.DataAnnotations;

namespace Warsztat.Model
{
    internal class Dostawca
    {
        [Key]
        public int Id { get; set; }
        public string? Nazwa { get; set; }
        public string? Email { get; set; }
        public int Telefon { get; set; }
        public Dostawca() { }

        public Dostawca(string nazwa, string email, int telefon)
        {
            Nazwa = nazwa;
            Email = email;
            Telefon = telefon;
        }
    }
}
