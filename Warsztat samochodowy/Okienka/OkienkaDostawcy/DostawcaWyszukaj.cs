using System.Data;

namespace Warsztat_samochodowy.Okienka.OkienkaDostawcy
{
    public partial class DostawcaWyszukaj : Form
    {
        public DostawcaWyszukaj()
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
                if (!string.IsNullOrEmpty(telefonWyszukaj.Text)) b = int.Parse(telefonWyszukaj.Text);
                else b = 0;
            }
            catch (Exception)
            {
                komunikat.Text = "ID i PESEL muszą być liczbami całkowitymi";
                return;
            }
            using (var kontekst = new KomunikacjaZBD())
            {
                IQueryable<Rekordy.Dostawca> wyniki = kontekst.dostawcy;
                if (!string.IsNullOrEmpty(emailWyszukaj.Text)) wyniki = wyniki
                        .Where(w => w.email!.Contains(emailWyszukaj.Text));
                if (!string.IsNullOrEmpty(nazwaWyszukaj.Text)) wyniki = wyniki
                        .Where(w => w.nazwa!.Contains(nazwaWyszukaj.Text));
                if (a != 0) wyniki = wyniki
                        .Where(w => w.Id.ToString().Contains(a.ToString()));
                if (b != 0) wyniki = wyniki
                        .Where(w => w.telefon.ToString().Contains(b.ToString()));
                znalezioneWyniki.Items.Clear();
                if (sortowanie.SelectedIndex == 0) wyniki = wyniki.OrderBy(w => w.Id);
                if (sortowanie.SelectedIndex == 1) wyniki = wyniki.OrderBy(w => w.nazwa);
                if (sortowanie.SelectedIndex == 2) wyniki = wyniki.OrderBy(w => w.email);
                if (sortowanie.SelectedIndex == 3) wyniki = wyniki.OrderBy(w => w.telefon);
                foreach (var w in wyniki)
                {
                    ListViewItem d = new(w.Id.ToString());
                    d.SubItems.Add(w.nazwa);
                    d.SubItems.Add(w.email);
                    d.SubItems.Add(w.telefon.ToString());
                    znalezioneWyniki.Items.Add(d);

                }
            }
        }
    }
}
