using System.Data;
using Warsztat.Model;

namespace Warsztat.Okienka.OkienkaKlienci
{
    public partial class KlientWyszukaj : Form
    {
        public KlientWyszukaj()
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
            string imie = imieWyszukaj.Text;
            string nazwisko = nazwiskoWyszukaj.Text;
            int index = sortowanie.SelectedIndex;
            try
            {
                if (!string.IsNullOrEmpty(peselWyszukaj.Text)) a = int.Parse(peselWyszukaj.Text);
                else a = 0;
                if (!string.IsNullOrEmpty(telefonWyszukaj.Text)) b = int.Parse(telefonWyszukaj.Text);
                else b = 0;
            }
            catch (Exception)
            {
                komunikat.Text = "Telefon i PESEL muszą być liczbami całkowitymi";
                return;
            }
            await Task.Run(() =>
            {
                using (var kontekst = new WarsztatBD())
                {
                    IQueryable<Klient> wyniki = kontekst.Klienci;
                    if (!string.IsNullOrEmpty(imie)) wyniki = wyniki
                            .Where(w => w.Imie!.Contains(imie));
                    if (!string.IsNullOrEmpty(nazwisko)) wyniki = wyniki
                            .Where(w => w.Nazwisko!.Contains(nazwisko));
                    if (a != 0) wyniki = wyniki
                            .Where(w => w.PESEL.ToString().Contains(a.ToString()));
                    if (b != 0) wyniki = wyniki
                            .Where(w => w.Telefon.ToString().Contains(b.ToString()));
                    znalezioneWyniki.Invoke(new Action(delegate ()
                    {
                        znalezioneWyniki.Items.Clear();
                    }));
                    if (index == 0) wyniki = wyniki.OrderBy(w => w.Imie);
                    if (index == 1) wyniki = wyniki.OrderBy(w => w.Nazwisko);
                    if (index == 2) wyniki = wyniki.OrderBy(w => w.PESEL);
                    if (index == 3) wyniki = wyniki.OrderBy(w => w.Telefon);
                    foreach (var w in wyniki)
                    {
                        ListViewItem kl = new(w.Imie);
                        kl.SubItems.Add(w.Nazwisko);
                        kl.SubItems.Add(w.PESEL.ToString());
                        kl.SubItems.Add(w.Telefon.ToString());
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
