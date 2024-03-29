﻿using System.Data;

namespace Warsztat.Okienka.OkienkaPracownicy
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
            using (var kontekst = new WarsztatBD())
            {
                try
                {
                    var pracownik = kontekst.Pracownicy.Where(k => k.PESEL == a).First();
                    kontekst.Pracownicy.Remove(pracownik);
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
