using Microsoft.IdentityModel.Tokens;
using System.Data;

namespace Warsztat.Okienka.OkienkaPracownicy
{
    public partial class PracownikEdytuj : Form
    {
        public PracownikEdytuj()
        {
            InitializeComponent();
        }

        private void wroc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void zmien_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            try
            {
                if (!pesel.Text.IsNullOrEmpty()) a = int.Parse(pesel.Text);
                else a = 0;
                if (!telefon.Text.IsNullOrEmpty()) b = int.Parse(telefon.Text);
                else b = 0;
            }
            catch (Exception)
            {
                komunikat.Text = "Telefon i PESEL muszą być liczbami całkowitymi";
                return;
            }
            using (var kontekst = new WarsztatBD())
            {
                try
                {
                    var pracownik = kontekst.Pracownicy.Where(p => p.PESEL == a).First();
                    if (!imie.Text.IsNullOrEmpty()) pracownik.Imie = imie.Text;
                    if (!nazwisko.Text.IsNullOrEmpty()) pracownik.Nazwisko = nazwisko.Text;
                    if (b != 0) pracownik.Telefon = b;
                    if (!rola.Text.IsNullOrEmpty()) pracownik.Rola = rola.Text;
                }
                catch (Exception)
                {
                    komunikat.Text = "Nie ma takiego pracownika";
                    return;
                }
                await kontekst.SaveChangesAsync();
                komunikat.Text = "Pomyślnie zmieniono dane pracownika";
            }

        }

        private void pesel_TextChanged(object sender, EventArgs e)
        {
            komunikat.Text = "";
        }

        private void imie_TextChanged(object sender, EventArgs e)
        {
            komunikat.Text = "";
        }

        private void nazwisko_TextChanged(object sender, EventArgs e)
        {
            komunikat.Text = "";
        }

        private void telefon_TextChanged(object sender, EventArgs e)
        {
            komunikat.Text = "";
        }

        private void rola_TextChanged(object sender, EventArgs e)
        {
            komunikat.Text = "";
        }
    }
}
