﻿using System.Data;

namespace Warsztat_samochodowy.Okienka.OkienkaPracownicy
{
    public partial class PracownikWyszukaj : Form
    {
        public PracownikWyszukaj()
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
                using (var kontekst = new KomunikacjaZBD())
                {
                    IQueryable<Rekordy.Pracownik> wyniki = kontekst.pracownicy;
                    if (!string.IsNullOrEmpty(imie)) wyniki = wyniki
                            .Where(w => w.imie!.Contains(imie));
                    if (!string.IsNullOrEmpty(nazwisko)) wyniki = wyniki
                            .Where(w => w.nazwisko!.Contains(nazwisko));
                    if (a != 0) wyniki = wyniki
                            .Where(w => w.PESEL.ToString().Contains(a.ToString()));
                    if (b != 0) wyniki = wyniki
                            .Where(w => w.telefon.ToString().Contains(b.ToString()));
                    if (!string.IsNullOrEmpty(rolaWyszukaj.Text)) wyniki = wyniki
                            .Where(w => w.rola!.Contains(rolaWyszukaj.Text));
                    znalezioneWyniki.Invoke(new Action(delegate ()
                    {
                        znalezioneWyniki.Items.Clear();
                    }));
                    if (index == 0) wyniki = wyniki.OrderBy(w => w.imie);
                    if (index == 1) wyniki = wyniki.OrderBy(w => w.nazwisko);
                    if (index == 2) wyniki = wyniki.OrderBy(w => w.PESEL);
                    if (index == 3) wyniki = wyniki.OrderBy(w => w.telefon);
                    if (index == 4) wyniki = wyniki.OrderBy(w => w.rola);
                    foreach (var w in wyniki)
                    {
                        ListViewItem kl = new(w.imie);
                        kl.SubItems.Add(w.nazwisko);
                        kl.SubItems.Add(w.PESEL.ToString());
                        kl.SubItems.Add(w.telefon.ToString());
                        kl.SubItems.Add(w.rola);
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
