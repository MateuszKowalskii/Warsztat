using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warsztat_samochodowy.Okienka.OkienkaDostawcy;

namespace Warsztat_samochodowy.Okienka.OkienkaMagazyn
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

        private void szukaj_Click(object sender, EventArgs e)
        {
            using (var kontekst = new KomunikacjaZBD())
            {
                IQueryable<Rekordy.Czesc> wyniki = kontekst.czesci;
                if (!string.IsNullOrEmpty(nazwaWyszukaj.Text)) wyniki = wyniki
                        .Where(w => w.nazwa!.Contains(nazwaWyszukaj.Text));
                if (!string.IsNullOrEmpty(kodWyszukaj.Text)) wyniki = wyniki
                        .Where(w => w.kod!.Contains(kodWyszukaj.Text));
                znalezioneWyniki.Items.Clear();
                if (sortowanie.SelectedIndex == 0) wyniki = wyniki.OrderBy(w => w.nazwa);
                if (sortowanie.SelectedIndex == 1) wyniki = wyniki.OrderBy(w => w.kod);
                if (sortowanie.SelectedIndex == 2) wyniki = wyniki.OrderBy(w => w.ilosc);
                foreach (var w in wyniki)
                {
                    ListViewItem cz = new(w.nazwa);
                    cz.SubItems.Add(w.kod);
                    cz.SubItems.Add(w.ilosc.ToString());
                    znalezioneWyniki.Items.Add(cz);

                }
            }
        }
    }
}
