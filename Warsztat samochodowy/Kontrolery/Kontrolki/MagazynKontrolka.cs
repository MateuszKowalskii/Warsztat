using Warsztat_samochodowy.Okienka.OkienkaMagazyn;

namespace Warsztat_samochodowy
{
    public partial class MagazynKontrolka : UserControl
    {
        public MagazynKontrolka()
        {
            InitializeComponent();
            this.Hide();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dodajZamowienie_Click(object sender, EventArgs e)
        {
            ZamowienieDodaj okienko = new();
            okienko.Show();
        }

        private void wyszukajZamowienie_Click(object sender, EventArgs e)
        {
            ZamowienieWyszukaj okienko = new();
            okienko.Show();
        }

        private void stanMagazynu_Click(object sender, EventArgs e)
        {
            CzescWyszukaj okienko = new();
            okienko.Show();
        }
    }
}
