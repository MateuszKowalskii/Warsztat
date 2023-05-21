using Microsoft.IdentityModel.Tokens;
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
    public partial class PracownikEdytuj : Form
    {
        public PracownikEdytuj()
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
                    var pracownik = kontekst.pracownicy.Where(p => p.PESEL == a).First();
                    if (!imie.Text.IsNullOrEmpty()) pracownik.imie = imie.Text;
                    if (!nazwisko.Text.IsNullOrEmpty()) pracownik.nazwisko = nazwisko.Text;
                    if (b != 0) pracownik.telefon = b;
                    if (!rola.Text.IsNullOrEmpty()) pracownik.rola = rola.Text;
                }
                catch (Exception)
                {
                    komunikat.Text = "Nie ma takiego pracownika";
                    return;
                }
                await kontekst.SaveChangesAsync();
                komunikat.Text = "Pomyślnie zmieniono dane pracownika";
            }

        }

        private void pesel_TextChanged(object sender, EventArgs e)
        {
            komunikat.Text = "";
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

        private void rola_TextChanged(object sender, EventArgs e)
        {
            komunikat.Text = "";
        }
    }
}
