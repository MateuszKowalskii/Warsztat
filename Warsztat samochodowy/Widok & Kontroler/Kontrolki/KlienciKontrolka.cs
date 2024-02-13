using Warsztat.Okienka.OkienkaKlienci;

namespace Warsztat
{
    public partial class KlienciKontrolka : UserControl
    {
        public KlienciKontrolka()
        {
            InitializeComponent();
            this.Hide();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            //program.panelGlowny.Show();
            //klienciStrona.Show();
            this.Hide();
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            KlientDodaj okienko = new();
            okienko.Show();
        }

        private void usun_Click(object sender, EventArgs e)
        {
            KlientUsun okienko = new();
            okienko.Show();
        }

        private void edytuj_Click(object sender, EventArgs e)
        {
            KlientEdytuj okienko = new();
            okienko.Show();
        }

        private void wyszukaj_Click(object sender, EventArgs e)
        {
            KlientWyszukaj okienko = new();
            okienko.Show();
        }
    }
}
