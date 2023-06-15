using Warsztat_samochodowy;
using Warsztat_samochodowy.Modele;

namespace Warsztat_samochodowy.Okienka.OkienkaDostawcy
{
    public partial class DostawcaDodaj : Form
    {
        public DostawcaDodaj()
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
            try
            {
                a = int.Parse(telefon.Text);
            }
            catch (Exception)
            {
                komunikat.Text = "Telefon musi być liczbą całkowitą";
                return;
            }
            try
            {
                Dostawca dostawca = new(nazwa.Text, email.Text, a);
                using (var kontekst = new KomunikacjaZBD())
                {
                    await kontekst.dostawcy.AddAsync(dostawca);
                    await kontekst.SaveChangesAsync();
                }

            }
            catch (Exception)
            {
                komunikat.Text = "Dostawca o podanej nazwie już istnieje w bazie";
                return;
            }
            komunikat.Text = "Pomyślnie dodano nowego dostawcę";
        }

        private void nazwa_TextChanged(object sender, EventArgs e)
        {
            komunikat.Text = "";
        }

    }
}
