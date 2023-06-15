using System.Data;

namespace Warsztat_samochodowy.Okienka.OkienkaZlecenia
{
    public partial class ZlecenieWykonano : Form
    {
        int idZlecenia;
        public ZlecenieWykonano()
        {
            InitializeComponent();
        }

        private async void zrealizowane_Click(object sender, EventArgs e)
        {
            using (var kontekst = new KomunikacjaZBD())
            {

                var zlecenieDoAktualizacji = kontekst.zlecenia.Where(z => z.Id == this.idZlecenia).First();
                zlecenieDoAktualizacji.zakonczone = true;

                await kontekst.SaveChangesAsync();
                komunikat.Text = "Zapamiętam";
                Thread.Sleep(1000);
                this.Close();
            }
        }

        public void zmienKomunikat(int id)
        {
            idZlecenia = id;
            komunikat.Text = "Dzisiaj planowo miało zostać wykonane zlecenie nr." + id + ". Czy zostało zrealizowane?";
        }

        private void nieZrealizowane_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
