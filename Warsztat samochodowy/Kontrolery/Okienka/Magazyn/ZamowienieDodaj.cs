using Warsztat_samochodowy.Modele;

namespace Warsztat_samochodowy.Okienka.OkienkaMagazyn
{
    public partial class ZamowienieDodaj : Form
    {
        public ZamowienieDodaj()
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
            string b;
            try
            {
                a = int.Parse(ilosc.Text);
                b = data.SelectionRange.Start.ToShortDateString();
            }
            catch (Exception)
            {
                komunikat.Text = "Ilość musi być liczbą całkowitą";
                return;
            }

            try
            {
                Zamowienie zamowienie = new(dostawca.Text, kod.Text, nazwa.Text, a, b);
                using (var kontekst = new KomunikacjaZBD())
                {
                    await kontekst.zamowienia.AddAsync(zamowienie);
                    await kontekst.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                komunikat.Text = "Wystąpił roblem z zapisaniem dostawy";
                return;
            }
            komunikat.Text = "Pomyślnie dodano zamówienie";


        }

        private void ZamowienieDodaj_Load(object sender, EventArgs e)
        {
            using (var kontekst = new KomunikacjaZBD())
            {
                IQueryable<Dostawca> wyniki = kontekst.dostawcy;
                foreach (var d in wyniki)
                {
                    dostawca.Items.Add(d.nazwa);
                }
            }
        }

        private void nazwa_TextChanged(object sender, EventArgs e)
        {
            komunikat.Text = "";
        }

        private void kod_TextChanged(object sender, EventArgs e)
        {
            komunikat.Text = "";
        }

        private void dostawca_SelectedIndexChanged(object sender, EventArgs e)
        {
            komunikat.Text = "";
        }

        private void ilosc_TextChanged(object sender, EventArgs e)
        {
            komunikat.Text = "";
        }
    }
}
