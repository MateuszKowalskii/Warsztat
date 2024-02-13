using System.Data;
using Warsztat;
using Warsztat.Model;

namespace Warsztat.Okienka.OkienkaDostawcy
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
                using (var kontekst = new WarsztatBD())
                {
                    IQueryable<Dostawca> wyniki = kontekst.Dostawcy;
                    if (!string.IsNullOrEmpty(email)) wyniki = wyniki
                            .Where(w => w.Email!.Contains(email));
                    if (!string.IsNullOrEmpty(nazwa)) wyniki = wyniki
                            .Where(w => w.Nazwa!.Contains(nazwa));
                    if (a != 0) wyniki = wyniki
                            .Where(w => w.Id.ToString().Contains(a.ToString()));
                    if (b != 0) wyniki = wyniki
                            .Where(w => w.Telefon.ToString().Contains(b.ToString()));
                    znalezioneWyniki.Invoke(new Action(delegate ()
                    {
                        znalezioneWyniki.Items.Clear();
                    }));
                    if (index == 0) wyniki = wyniki.OrderBy(w => w.Id);
                    if (index == 1) wyniki = wyniki.OrderBy(w => w.Nazwa);
                    if (index == 2) wyniki = wyniki.OrderBy(w => w.Email);
                    if (index == 3) wyniki = wyniki.OrderBy(w => w.Telefon);
                    foreach (var w in wyniki)
                    {
                        ListViewItem d = new(w.Id.ToString());
                        d.SubItems.Add(w.Nazwa);
                        d.SubItems.Add(w.Email);
                        d.SubItems.Add(w.Telefon.ToString());
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
