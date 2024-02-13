using System.Data;
using Warsztat.Model;

namespace Warsztat.Okienka.OkienkaMagazyn
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
                using (var kontekst = new WarsztatBD())
                {
                    IQueryable<Czesc> wyniki = kontekst.Czesci;
                    if (!string.IsNullOrEmpty(nazwa)) wyniki = wyniki
                            .Where(w => w.Nazwa!.Contains(nazwa));
                    if (!string.IsNullOrEmpty(kod)) wyniki = wyniki
                            .Where(w => w.Kod!.Contains(kod));
                    znalezioneWyniki.Invoke(new Action(delegate ()
                    {
                        znalezioneWyniki.Items.Clear();
                    }));
                    if (index == 0) wyniki = wyniki.OrderBy(w => w.Nazwa);
                    if (index == 1) wyniki = wyniki.OrderBy(w => w.Kod);
                    if (index == 2) wyniki = wyniki.OrderBy(w => w.Ilosc);
                    foreach (var w in wyniki)
                    {
                        ListViewItem cz = new(w.Nazwa);
                        cz.SubItems.Add(w.Kod);
                        cz.SubItems.Add(w.Ilosc.ToString());
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
