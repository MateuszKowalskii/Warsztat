using System.Data;
using Warsztat.Model;

namespace Warsztat.Okienka.OkienkaZlecenia
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

        private async void szukaj_Click(object sender, EventArgs e)
        {

            string status = statusWyszukaj.Text;
            int index = sortowanie.SelectedIndex;
                await Task.Run(() =>
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
                    using (var kontekst = new WarsztatBD())
                    {
                        IQueryable<Zlecenie> wyniki = kontekst.Zlecenia;
                        if (!string.IsNullOrEmpty(idWyszukaj.Text)) wyniki = wyniki
                                .Where(w => w.Id.ToString().Contains(a.ToString()));
                        if (!string.IsNullOrEmpty(pesel.Text)) wyniki = wyniki
                                .Where(w => w.ZleceniodawcaPESEL.ToString().Contains(b.ToString()));

                        if (status == "Zakończone") wyniki = wyniki
                                .Where(w => w.Zakonczone == true);
                        if (status == "W trakcie") wyniki = wyniki
                                .Where(w => w.Zakonczone == false);
                        znalezioneWyniki.Invoke(new Action(delegate ()
                        {
                            znalezioneWyniki.Items.Clear();
                        }));

                        if (index == 0) wyniki = wyniki.OrderBy(w => w.Id);
                        if (index == 1) wyniki = wyniki.OrderBy(w => w.Oplata);
                        if (index == 2) wyniki = wyniki.OrderBy(w => w.ZleceniodawcaPESEL);
                        if (index == 3) wyniki = wyniki.OrderBy(w => w.DataWykonania);
                        foreach (var w in wyniki)
                        {
                            ListViewItem z = new(w.ZleceniodawcaPESEL.ToString());
                            z.SubItems.Add(w.Id.ToString());
                            z.SubItems.Add(w.Oplata.ToString());
                            z.SubItems.Add(w.Zakonczone.ToString());
                            z.SubItems.Add(w.DataWykonania);
                            znalezioneWyniki.Invoke(new Action(delegate ()
                            {
                                znalezioneWyniki.Items.Add(z);
                            }));
                        }
                    }
                });
        }
    }
}
