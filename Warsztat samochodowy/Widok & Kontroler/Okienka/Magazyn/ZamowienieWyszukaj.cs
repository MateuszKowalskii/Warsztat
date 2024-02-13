using System.Data;
using Warsztat.Model;

namespace Warsztat.Okienka.OkienkaMagazyn
{
    public partial class ZamowienieWyszukaj : Form
    {
        public ZamowienieWyszukaj()
        {
            InitializeComponent();
        }

        private void wroc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void szukaj_Click(object sender, EventArgs e)
        {
            string nazwa = nazwaWyszukaj.Text;
            string kod = kodWyszukaj.Text;
            string dostawca = dostawcaWyszukaj.Text;
            int index = sortowanie.SelectedIndex;

            await Task.Run(() =>
            {

                using (var kontekst = new WarsztatBD())
                {
                    IQueryable<Zamowienie> wyniki = kontekst.Zamowienia;
                    if (!string.IsNullOrEmpty(nazwa)) wyniki = wyniki
                            .Where(w => w.Nazwa!.Contains(nazwa));
                    if (!string.IsNullOrEmpty(kod)) wyniki = wyniki
                            .Where(w => w.Kod!.Contains(kod));
                    if (!string.IsNullOrEmpty(dostawca)) wyniki = wyniki
                            .Where(w => w.DostawcaNazwa!.Contains(dostawca));
                    znalezioneWyniki.Invoke(new Action(delegate ()
                    {
                        znalezioneWyniki.Items.Clear();
                    }));
                    if (index == 0) wyniki = wyniki.OrderBy(w => w.Nazwa);
                    if (index == 1) wyniki = wyniki.OrderBy(w => w.Kod);
                    if (index == 2) wyniki = wyniki.OrderBy(w => w.DostawcaNazwa);
                    if (index == 3) wyniki = wyniki.OrderBy(w => w.KiedyDotrze);
                    foreach (var w in wyniki)
                    {
                        ListViewItem kl = new(w.Nazwa);
                        kl.SubItems.Add(w.Kod);
                        kl.SubItems.Add(w.DostawcaNazwa);
                        kl.SubItems.Add(w.KiedyDotrze);
                        znalezioneWyniki.Invoke(new Action(delegate ()
                        {
                            znalezioneWyniki.Items.Add(kl);
                        }));

                    }
                }
            });
        }
    }
}
