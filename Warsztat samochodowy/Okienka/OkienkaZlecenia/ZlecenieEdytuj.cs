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

namespace Warsztat_samochodowy.Okienka.OkienkaZlecenia
{
    public partial class ZlecenieEdytuj : Form
    {
        public ZlecenieEdytuj()
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
            decimal b;
            try
            {
                if (!Id.Text.IsNullOrEmpty()) a = int.Parse(Id.Text);
                else
                {
                    komunikat.Text = "Podaj Id";
                    return;
                }

            }
            catch (Exception)
            {
                komunikat.Text = "Id musi być liczbą całkowitą";
                return;
            }
            try
            {
                if (!oplata.Text.IsNullOrEmpty())
                {
                    b = decimal.Parse(oplata.Text);
                    if (b < 0) throw new Exception();
                }
                else b = -10;
            }
            catch (Exception)
            {
                komunikat.Text = "Opłata musi być liczbą nieujemną";
                return;
            }

            using (var kontekst = new KomunikacjaZBD())
            {
                try
                {
                    var zlecenie = kontekst.zlecenia.Where(z => z.Id == a).First();
                    if (b != -10) zlecenie.oplata = b;
                    if (!status.Text.IsNullOrEmpty())
                    {
                        if (status.Text == "Zakończone") zlecenie.zakonczone = true;
                        if (status.Text == "W trakcie") zlecenie.zakonczone = false;
                    }
                    zlecenie.dataWykonania = data.SelectionRange.Start.ToShortDateString();
                }
                catch (Exception)
                {
                    komunikat.Text = "Nie ma takiego zlecenia";
                    return;
                }
                await kontekst.SaveChangesAsync();
                komunikat.Text = "Pomyślnie zmieniono dane zlecenia";
            }
        }

        private void ZlecenieEdytuj_Load(object sender, EventArgs e)
        {
            using (var kontekst = new KomunikacjaZBD())
            {
                IQueryable<Rekordy.Pracownik> pracownicy = kontekst.pracownicy;
                foreach (var p in pracownicy)
                {
                    listaPracownikow.Items.Add(p.PESEL);
                }
            }
        }

        private async void dodajPracownika_Click(object sender, EventArgs e)
        {
            komunikat.Text = "";
            int pracownikPesel;

            if (listaPracownikow.Text.IsNullOrEmpty())
            {
                komunikat.Text = "Wybierz pracownika";
                return;
            }
            else pracownikPesel = int.Parse(listaPracownikow.Text);

            int a;
            try
            {
                if (!Id.Text.IsNullOrEmpty()) a = int.Parse(Id.Text);
                else
                {
                    komunikat.Text = "Podaj Id";
                    return;
                }

            }
            catch (Exception)
            {
                komunikat.Text = "Id musi być liczbą całkowitą";
                return;
            }
            using (var kontekst = new KomunikacjaZBD())
            {
                var zlecenie = kontekst.zlecenia.Where(z => z.Id == a).First();
                var pracownik = kontekst.pracownicy.Where(p => p.PESEL == pracownikPesel).First();
                zlecenie.pracownicy.Add(pracownik);
                await kontekst.SaveChangesAsync();
                komunikat.Text = "Pomyślnie przypisano pracownika";
            }


        }

        private void listaPracownikow_SelectedIndexChanged(object sender, EventArgs e)
        {
            komunikat.Text = "";
        }
    }
}
