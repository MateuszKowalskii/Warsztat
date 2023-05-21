namespace Warsztat_samochodowy.Okienka.OkienkaZlecenia
{
    public partial class ZlecenieDodaj : Form
    {
        public ZlecenieDodaj()
        {
            InitializeComponent();
        }

        private void wroc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void dodaj_Click(object sender, EventArgs e)
        {
            komunikat.Text = "";
            int a;
            decimal b;
            string c;
            try
            {
                a = int.Parse(pesel.Text);
                b = decimal.Parse(wynagrodzenie.Text);
            }
            catch (Exception)
            {
                komunikat.Text = "Pesel i wynagrodzenie muszą być liczbami";
                return;
            }
            try
            {
                c = data.SelectionRange.Start.ToShortDateString();
            }
            catch
            {
                komunikat.Text = "Wybierz datę";
                return;
            }

            try
            {
                Rekordy.Zlecenie zlecenie = new(a, b, c);
                using (var kontekst = new KomunikacjaZBD())
                {
                    await kontekst.zlecenia.AddAsync(zlecenie);
                    await kontekst.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                komunikat.Text = "Wystąpił roblem z zapisaniem zlecenia";
                return;
            }
            komunikat.Text = "Pomyślnie dodano zlecenie";


        }

        private void ZlecenieDodaj_Load(object sender, EventArgs e)
        {
            using (var kontekst = new KomunikacjaZBD())
            {
                IQueryable<Rekordy.Klient> wyniki = kontekst.klienci;
                foreach (var k in wyniki)
                {
                    pesel.Items.Add(k.PESEL);
                }
            }
        }

        private void wynagrodzenie_TextChanged(object sender, EventArgs e)
        {
            komunikat.Text = " ";
        }

        private void pesel_SelectedIndexChanged(object sender, EventArgs e)
        {
            komunikat.Text = " ";
        }

        private void data_DateChanged(object sender, DateRangeEventArgs e)
        {
            komunikat.Text = " ";
        }
    }
}
