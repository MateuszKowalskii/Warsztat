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

        private async void szukaj_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            string email = emailWyszukaj.Text;
            string nazwa = emailWyszukaj.Text;
            int index = sortowanie.SelectedIndex;
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
            await Task.Run(() => { 
                using (var kontekst = new KomunikacjaZBD())
                {
                    IQueryable<Rekordy.Dostawca> wyniki = kontekst.dostawcy;
                    if (!string.IsNullOrEmpty(email)) wyniki = wyniki
                            .Where(w => w.email!.Contains(email));
                    if (!string.IsNullOrEmpty(nazwa)) wyniki = wyniki
                            .Where(w => w.nazwa!.Contains(nazwa));
                    if (a != 0) wyniki = wyniki
                            .Where(w => w.Id.ToString().Contains(a.ToString()));
                    if (b != 0) wyniki = wyniki
                            .Where(w => w.telefon.ToString().Contains(b.ToString()));
                    znalezioneWyniki.Invoke(new Action(delegate ()
                    {
                        znalezioneWyniki.Items.Clear();
                    }));
                    if (index == 0) wyniki = wyniki.OrderBy(w => w.Id);
                    if (index == 1) wyniki = wyniki.OrderBy(w => w.nazwa);
                    if (index == 2) wyniki = wyniki.OrderBy(w => w.email);
                    if (index == 3) wyniki = wyniki.OrderBy(w => w.telefon);
                    foreach (var w in wyniki)
                    {
                        ListViewItem d = new(w.Id.ToString());
                        d.SubItems.Add(w.nazwa);
                        d.SubItems.Add(w.email);
                        d.SubItems.Add(w.telefon.ToString());
                        //znalezioneWyniki.Items.Add(d);
                        znalezioneWyniki.Invoke(new Action(delegate ()
                        {
                            znalezioneWyniki.Items.Add(d);
                        }));
                    }
                }
            });
        }
    }
}
