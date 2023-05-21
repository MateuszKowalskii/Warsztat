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

        private void szukaj_Click(object sender, EventArgs e)
        {
            using (var kontekst = new KomunikacjaZBD())
            {
                IQueryable<Rekordy.Zamowienie> wyniki = kontekst.zamowienia;
                if (!string.IsNullOrEmpty(nazwaWyszukaj.Text)) wyniki = wyniki
                        .Where(w => w.nazwa!.Contains(nazwaWyszukaj.Text));
                if (!string.IsNullOrEmpty(kodWyszukaj.Text)) wyniki = wyniki
                        .Where(w => w.kod!.Contains(kodWyszukaj.Text));
                if (!string.IsNullOrEmpty(dostawcaWyszukaj.Text)) wyniki = wyniki
                        .Where(w => w.dostawcaNazwa!.Contains(dostawcaWyszukaj.Text));
                znalezioneWyniki.Items.Clear();
                if (sortowanie.SelectedIndex == 0) wyniki = wyniki.OrderBy(w => w.nazwa);
                if (sortowanie.SelectedIndex == 1) wyniki = wyniki.OrderBy(w => w.kod);
                if (sortowanie.SelectedIndex == 2) wyniki = wyniki.OrderBy(w => w.dostawcaNazwa);
                if (sortowanie.SelectedIndex == 3) wyniki = wyniki.OrderBy(w => w.kiedyDotrze);
                foreach (var w in wyniki)
                {
                    ListViewItem kl = new(w.nazwa);
                    kl.SubItems.Add(w.kod);
                    kl.SubItems.Add(w.dostawcaNazwa);
                    kl.SubItems.Add(w.kiedyDotrze);
                    znalezioneWyniki.Items.Add(kl);

                }
            }
        }
    }
}
