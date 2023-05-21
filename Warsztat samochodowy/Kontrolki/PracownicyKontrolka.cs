using Warsztat_samochodowy.Okienka.OkienkaPracownicy;

namespace Warsztat_samochodowy
{
    public partial class PracownicyKontrolka : UserControl
    {
        public PracownicyKontrolka()
        {
            InitializeComponent();
            this.Hide();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void edytuj_Click(object sender, EventArgs e)
        {
            PracownikEdytuj okienko = new();
            okienko.Show();
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            PracownikDodaj okienko = new();
            okienko.Show();
        }

        private void wyszukaj_Click(object sender, EventArgs e)
        {
            PracownikWyszukaj okienko = new();
            okienko.Show();
        }

        private void usun_Click(object sender, EventArgs e)
        {
            PracownikUsun okienko = new();
            okienko.Show();
        }
    }
}
