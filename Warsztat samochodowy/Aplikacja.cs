using Warsztat_samochodowy.Zdarzenia;

namespace Warsztat_samochodowy
{
    public partial class Aplikacja : Form
    {
        public Aplikacja()
        {
            InitializeComponent();
        }

        private void klienci_Click(object sender, EventArgs e)
        {
            panelGlowny.SendToBack();
            klienciStrona.Show();
        }

        private void zamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pracownicy_Click(object sender, EventArgs e)
        {
            panelGlowny.SendToBack();
            pracownicyStrona.Show();
        }

        private void zlecenia_Click(object sender, EventArgs e)
        {
            panelGlowny.SendToBack();
            zleceniaStrona.Show();
        }

        private void dostawcy_Click(object sender, EventArgs e)
        {
            panelGlowny.SendToBack();
            dostawcyStrona.Show();
        }

        private void magazyn_Click(object sender, EventArgs e)
        {
            panelGlowny.SendToBack();
            magazynStrona.Show();
        }

        private void zakoncz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Aplikacja_Load(object sender, EventArgs e)
        {
            MenedzerZdarzen mz = new();
            Informator inf = new(this.powiadomienia);
            ZmieniaczStatusu zs = new();

            mz.startProgramu += inf.informuj;
            mz.startProgramu2 += zs.zapytajOZmianeStatusu;
            mz.sprawdzTerminy();
        }

    }
}