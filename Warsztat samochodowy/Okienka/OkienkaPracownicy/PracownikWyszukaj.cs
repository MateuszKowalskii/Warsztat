using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void szukaj_Click(object sender, EventArgs e)
        {
            int a;
            int b;
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
            using (var kontekst = new KomunikacjaZBD())
            {
                IQueryable<Rekordy.Pracownik> wyniki = kontekst.pracownicy;
                if (!string.IsNullOrEmpty(imieWyszukaj.Text)) wyniki = wyniki
                        .Where(w => w.imie!.Contains(imieWyszukaj.Text));
                if (!string.IsNullOrEmpty(nazwiskoWyszukaj.Text)) wyniki = wyniki
                        .Where(w => w.nazwisko!.Contains(nazwiskoWyszukaj.Text));
                if (a != 0) wyniki = wyniki
                        .Where(w => w.PESEL.ToString().Contains(a.ToString()));
                if (b != 0) wyniki = wyniki
                        .Where(w => w.telefon.ToString().Contains(b.ToString()));
                if (!string.IsNullOrEmpty(rolaWyszukaj.Text)) wyniki = wyniki
                        .Where(w => w.rola!.Contains(rolaWyszukaj.Text));
                znalezioneWyniki.Items.Clear();
                if (sortowanie.SelectedIndex == 0) wyniki = wyniki.OrderBy(w => w.imie);
                if (sortowanie.SelectedIndex == 1) wyniki = wyniki.OrderBy(w => w.nazwisko);
                if (sortowanie.SelectedIndex == 2) wyniki = wyniki.OrderBy(w => w.PESEL);
                if (sortowanie.SelectedIndex == 3) wyniki = wyniki.OrderBy(w => w.telefon);
                if (sortowanie.SelectedIndex == 4) wyniki = wyniki.OrderBy(w => w.rola);
                foreach (var w in wyniki)
                {
                    ListViewItem kl = new(w.imie);
                    kl.SubItems.Add(w.nazwisko);
                    kl.SubItems.Add(w.PESEL.ToString());
                    kl.SubItems.Add(w.telefon.ToString());
                    kl.SubItems.Add(w.rola);
                    znalezioneWyniki.Items.Add(kl);

                }
            }
        }
    }
}
