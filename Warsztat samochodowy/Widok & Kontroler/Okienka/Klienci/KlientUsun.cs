using System.Data;
using Warsztat.Model;

namespace Warsztat.Okienka.OkienkaKlienci
{
    public partial class KlientUsun : Form
    {
        public KlientUsun()
        {
            InitializeComponent();
        }

        private void wroc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void usun_Click(object sender, EventArgs e)
        {
            int a;
            try
            {
                a = int.Parse(pesel.Text);
            }
            catch (Exception)
            {
                komunikat.Text = "PESEL musi być liczbą całkowitą";
                return;
            }
            using (var kontekst = new WarsztatBD())
            {
                try
                {
                    var klient = kontekst.Klienci.Where(k => k.PESEL == a).First();
                    kontekst.Klienci.Remove(klient);
                }
                catch (Exception)
                {
                    komunikat.Text = "Nie ma takiego klienta";
                    return;
                }
                await kontekst.SaveChangesAsync();
                komunikat.Text = "Pomyślnie usunięto klienta";
            }
        }

        private void pesel_TextChanged(object sender, EventArgs e)
        {
            komunikat.Text = "";
        }
    }
}
