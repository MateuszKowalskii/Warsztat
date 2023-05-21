using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warsztat_samochodowy.Rekordy;

namespace Warsztat_samochodowy.Okienka.OkienkaKlienci
{
    public partial class KlientEdytuj : Form
    {
        public KlientEdytuj()
        {
            InitializeComponent();
        }

        private void wroc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void zmien_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            try
            {
                if (!pesel.Text.IsNullOrEmpty()) a = int.Parse(pesel.Text);
                else a = 0;
                if (!telefon.Text.IsNullOrEmpty()) b = int.Parse(telefon.Text);
                else b = 0;
            }
            catch (Exception)
            {
                komunikat.Text = "Telefon i PESEL muszą być liczbami całkowitymi";
                return;
            }
            using (var kontekst = new KomunikacjaZBD())
            {
                try
                {
                    var klient = kontekst.klienci.Where(k => k.PESEL == a).First();
                    if (!imie.Text.IsNullOrEmpty()) klient.imie = imie.Text;
                    if (!nazwisko.Text.IsNullOrEmpty()) klient.nazwisko = nazwisko.Text;
                    if (b != 0) klient.telefon = b;
                }
                catch (Exception)
                {
                    komunikat.Text = "Nie ma takiego klienta";
                    return;
                }
                await kontekst.SaveChangesAsync();
                komunikat.Text = "Pomyślnie zmieniono dane klienta";
            }

        }

        private void imie_TextChanged(object sender, EventArgs e)
        {
            komunikat.Text = "";
        }

        private void nazwisko_TextChanged(object sender, EventArgs e)
        {
            komunikat.Text = "";
        }

        private void telefon_TextChanged(object sender, EventArgs e)
        {
            komunikat.Text = "";
        }

        private void pesel_TextChanged(object sender, EventArgs e)
        {
            komunikat.Text = "";
        }
    }
}
