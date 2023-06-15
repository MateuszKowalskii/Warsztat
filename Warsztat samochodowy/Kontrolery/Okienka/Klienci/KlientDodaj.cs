using Warsztat_samochodowy;
using Warsztat_samochodowy.Modele;

namespace Warsztat_samochodowy.Okienka.OkienkaKlienci
{
    public partial class KlientDodaj : Form
    {
        public KlientDodaj()
        {
            InitializeComponent();
        }

        private void wroc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void dodaj_Click(object sender, EventArgs e)
        {
            komunikat.Text = "";
            int a;
            int b;
            try
            {
                a = int.Parse(pesel.Text);
                b = int.Parse(telefon.Text);
            }
            catch (Exception)
            {
                komunikat.Text = "Telefon i PESEL muszą być liczbami całkowitymi";
                return;
            }
            try
            {
                Klient klient = new(a, imie.Text, nazwisko.Text, b);
                using (var kontekst = new KomunikacjaZBD())
                {
                    await kontekst.klienci.AddAsync(klient);
                    await kontekst.SaveChangesAsync();
                }

            }
            catch (Exception)
            {
                komunikat.Text = "Klient o podanym PESELu już istnieje w bazie";
                return;
            }
            komunikat.Text = "Pomyślnie dodano klienta";
        }

        private void pesel_TextChanged(object sender, EventArgs e)
        {
            komunikat.Text = "";
        }
    }
}
