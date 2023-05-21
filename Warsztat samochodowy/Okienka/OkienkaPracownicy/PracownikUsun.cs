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
    public partial class PracownikUsun : Form
    {
        public PracownikUsun()
        {
            InitializeComponent();
        }

        private void wroc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void usun_Click(object sender, EventArgs e)
        {
            int a;
            try
            {
                a = int.Parse(pesel.Text);
            }
            catch (Exception)
            {
                komunikat.Text = "PESEL musi być liczbą całkowitą";
                return;
            }
            using (var kontekst = new KomunikacjaZBD())
            {
                try
                {
                    var pracownik = kontekst.pracownicy.Where(k => k.PESEL == a).First();
                    kontekst.pracownicy.Remove(pracownik);
                }
                catch (Exception)
                {
                    komunikat.Text = "Nie ma takiego pracownika";
                    return;
                }
                await kontekst.SaveChangesAsync();
                komunikat.Text = "Pomyślnie usunięto pracownika";
            }
        }

        private void pesel_TextChanged(object sender, EventArgs e)
        {
            komunikat.Text = "";
        }
    }
}
