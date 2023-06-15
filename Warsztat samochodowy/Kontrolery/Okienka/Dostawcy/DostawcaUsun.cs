using System.Data;

namespace Warsztat_samochodowy.Okienka.OkienkaDostawcy
{
    public partial class DostawcaUsun : Form
    {
        public DostawcaUsun()
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
                a = int.Parse(id.Text);
            }
            catch (Exception)
            {
                komunikat.Text = "ID musi być liczbą całkowitą";
                return;
            }
            using (var kontekst = new KomunikacjaZBD())
            {
                try
                {
                    var dostawca = kontekst.dostawcy.Where(k => k.Id == a).First();
                    kontekst.dostawcy.Remove(dostawca);
                }
                catch (Exception)
                {
                    komunikat.Text = "Nie ma takiego dostawcy";
                    return;
                }
                await kontekst.SaveChangesAsync();
                komunikat.Text = "Pomyślnie usunięto dostawcę";
            }
        }
    }
}
