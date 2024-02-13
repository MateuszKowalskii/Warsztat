using Warsztat.Okienka.OkienkaDostawcy;

namespace Warsztat
{
    public partial class DostawcyKontrolka : UserControl
    {
        public DostawcyKontrolka()
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
            DostawcaDodaj okienko = new();
            okienko.Show();
        }

        private void edytuj_Click(object sender, EventArgs e)
        {
            DostawcaEdytuj okienko = new();
            okienko.Show();
        }

        private void wyszukaj_Click(object sender, EventArgs e)
        {
            DostawcaWyszukaj okienko = new();
            okienko.Show();
        }

        private void usun_Click(object sender, EventArgs e)
        {
            DostawcaUsun okienko = new();
            okienko.Show();
        }
    }
}
