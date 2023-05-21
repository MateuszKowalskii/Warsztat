using System.Data;

namespace Warsztat_samochodowy.Okienka.OkienkaZlecenia
{
    public partial class ZlecenieWyszukaj : Form
    {
        public ZlecenieWyszukaj()
        {
            InitializeComponent();
        }

        private void wroc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void szukaj_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            try
            {
                if (!string.IsNullOrEmpty(idWyszukaj.Text)) a = int.Parse(idWyszukaj.Text);
                else a = 0;
                if (!string.IsNullOrEmpty(pesel.Text)) b = int.Parse(pesel.Text);
                else b = 0;
            }
            catch (Exception)
            {
                komunikat.Text = "ID i PESEL muszą być liczbami całkowitymi";
                return;
            }
            using (var kontekst = new KomunikacjaZBD())
            {
                IQueryable<Rekordy.Zlecenie> wyniki = kontekst.zlecenia;
                if (!string.IsNullOrEmpty(idWyszukaj.Text)) wyniki = wyniki
                        .Where(w => w.Id.ToString().Contains(a.ToString()));
                if (!string.IsNullOrEmpty(pesel.Text)) wyniki = wyniki
                        .Where(w => w.zleceniodawcaPESEL.ToString().Contains(b.ToString()));
                if (statusWyszukaj.Text == "Zakończone") wyniki = wyniki
                        .Where(w => w.zakonczone == true);
                if (statusWyszukaj.Text == "W trakcie") wyniki = wyniki
                        .Where(w => w.zakonczone == false);
                znalezioneWyniki.Items.Clear();

                if (sortowanie.SelectedIndex == 0) wyniki = wyniki.OrderBy(w => w.Id);
                if (sortowanie.SelectedIndex == 1) wyniki = wyniki.OrderBy(w => w.oplata);
                if (sortowanie.SelectedIndex == 2) wyniki = wyniki.OrderBy(w => w.zleceniodawcaPESEL);
                if (sortowanie.SelectedIndex == 3) wyniki = wyniki.OrderBy(w => w.dataWykonania);
                foreach (var w in wyniki)
                {
                    ListViewItem z = new(w.zleceniodawcaPESEL.ToString());
                    z.SubItems.Add(w.Id.ToString());
                    z.SubItems.Add(w.oplata.ToString());
                    z.SubItems.Add(w.zakonczone.ToString());
                    z.SubItems.Add(w.dataWykonania);
                    znalezioneWyniki.Items.Add(z);

                }
            }
        }
    }
}
