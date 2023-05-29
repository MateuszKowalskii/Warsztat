using System.Data;

namespace Warsztat_samochodowy.Okienka.OkienkaMagazyn
{
    public partial class CzescWyszukaj : Form
    {
        public CzescWyszukaj()
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
            int index = sortowanie.SelectedIndex;
            await Task.Run(() =>
            {
                using (var kontekst = new KomunikacjaZBD())
                {
                    IQueryable<Rekordy.Czesc> wyniki = kontekst.czesci;
                    if (!string.IsNullOrEmpty(nazwa)) wyniki = wyniki
                            .Where(w => w.nazwa!.Contains(nazwa));
                    if (!string.IsNullOrEmpty(kod)) wyniki = wyniki
                            .Where(w => w.kod!.Contains(kod));
                    znalezioneWyniki.Invoke(new Action(delegate ()
                    {
                        znalezioneWyniki.Items.Clear();
                    }));
                    if (index == 0) wyniki = wyniki.OrderBy(w => w.nazwa);
                    if (index == 1) wyniki = wyniki.OrderBy(w => w.kod);
                    if (index == 2) wyniki = wyniki.OrderBy(w => w.ilosc);
                    foreach (var w in wyniki)
                    {
                        ListViewItem cz = new(w.nazwa);
                        cz.SubItems.Add(w.kod);
                        cz.SubItems.Add(w.ilosc.ToString());
                        znalezioneWyniki.Invoke(new Action(delegate ()
                        {
                            znalezioneWyniki.Items.Add(cz);
                        }));

                    }
                }
            });
        }
    }
}
