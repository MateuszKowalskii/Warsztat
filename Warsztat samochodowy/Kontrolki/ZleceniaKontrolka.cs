using Warsztat_samochodowy.Okienka.OkienkaMagazyn;
using Warsztat_samochodowy.Okienka.OkienkaZlecenia;

namespace Warsztat_samochodowy
{
    public partial class ZleceniaKontrolka : UserControl
    {
        public ZleceniaKontrolka()
        {
            InitializeComponent();
            this.Hide();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            ZlecenieDodaj okienko = new();
            okienko.Show();
        }

        private void edytuj_Click(object sender, EventArgs e)
        {
            ZlecenieEdytuj okienko = new();
            okienko.Show();
        }

        private void wyszukaj_Click(object sender, EventArgs e)
        {
            ZlecenieWyszukaj okienko = new();
            okienko.Show();
        }
    }
}
