using Warsztat_samochodowy.Modele;

namespace Warsztat_samochodowy.Okienka.OkienkaPracownicy
{
    public partial class PracownikDodaj : Form
    {
        public PracownikDodaj()
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
                Pracownik pracownik = new(a, imie.Text, nazwisko.Text, b, rola.Text);
                using (var kontekst = new KomunikacjaZBD())
                {
                    await kontekst.pracownicy.AddAsync(pracownik);
                    await kontekst.SaveChangesAsync();
                }

            }
            catch (Exception)
            {
                komunikat.Text = "Pracownik o podanym PESELu już istnieje w bazie";
                return;
            }
            komunikat.Text = "Pomyślnie dodano Pracownika";
        }

        private void pesel_TextChanged(object sender, EventArgs e)
        {
            komunikat.Text = "";
        }
    }
}
