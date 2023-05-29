using System.Data;

namespace Warsztat_samochodowy.Okienka.OkienkaMagazyn
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

                using (var kontekst = new KomunikacjaZBD())
                {
                    IQueryable<Rekordy.Zamowienie> wyniki = kontekst.zamowienia;
                    if (!string.IsNullOrEmpty(nazwa)) wyniki = wyniki
                            .Where(w => w.nazwa!.Contains(nazwa));
                    if (!string.IsNullOrEmpty(kod)) wyniki = wyniki
                            .Where(w => w.kod!.Contains(kod));
                    if (!string.IsNullOrEmpty(dostawca)) wyniki = wyniki
                            .Where(w => w.dostawcaNazwa!.Contains(dostawca));
                    znalezioneWyniki.Invoke(new Action(delegate ()
                    {
                        znalezioneWyniki.Items.Clear();
                    }));
                    if (index == 0) wyniki = wyniki.OrderBy(w => w.nazwa);
                    if (index == 1) wyniki = wyniki.OrderBy(w => w.kod);
                    if (index == 2) wyniki = wyniki.OrderBy(w => w.dostawcaNazwa);
                    if (index == 3) wyniki = wyniki.OrderBy(w => w.kiedyDotrze);
                    foreach (var w in wyniki)
                    {
                        ListViewItem kl = new(w.nazwa);
                        kl.SubItems.Add(w.kod);
                        kl.SubItems.Add(w.dostawcaNazwa);
                        kl.SubItems.Add(w.kiedyDotrze);
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
