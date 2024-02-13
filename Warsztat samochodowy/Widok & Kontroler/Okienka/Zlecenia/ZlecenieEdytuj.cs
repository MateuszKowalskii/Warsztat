using Microsoft.IdentityModel.Tokens;
using System.Data;
using Warsztat.Model;

namespace Warsztat.Okienka.OkienkaZlecenia
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

            using (var kontekst = new WarsztatBD())
            {
                try
                {
                    var zlecenie = kontekst.Zlecenia.Where(z => z.Id == a).First();
                    if (b != -10) zlecenie.Oplata = b;
                    if (!status.Text.IsNullOrEmpty())
                    {
                        if (status.Text == "Zakończone") zlecenie.Zakonczone = true;
                        if (status.Text == "W trakcie") zlecenie.Zakonczone = false;
                    }
                    zlecenie.DataWykonania = data.SelectionRange.Start.ToShortDateString();
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
            using (var kontekst = new WarsztatBD())
            {
                IQueryable<Pracownik> pracownicy = kontekst.Pracownicy;
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
            using (var kontekst = new WarsztatBD())
            {
                var zlecenie = kontekst.Zlecenia.Where(z => z.Id == a).First();
                var pracownik = kontekst.Pracownicy.Where(p => p.PESEL == pracownikPesel).First();
                zlecenie.Pracownicy.Add(pracownik);
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
