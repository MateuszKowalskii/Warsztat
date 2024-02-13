using Microsoft.IdentityModel.Tokens;
using System.Data;

namespace Warsztat.Okienka.OkienkaDostawcy
{
    public partial class DostawcaEdytuj : Form
    {
        public DostawcaEdytuj()
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
                if (!id.Text.IsNullOrEmpty()) a = int.Parse(id.Text);
                else a = 0;
                if (!telefon.Text.IsNullOrEmpty()) b = int.Parse(telefon.Text);
                else b = 0;
            }
            catch (Exception)
            {
                komunikat.Text = "Telefon i ID muszą być liczbami całkowitymi";
                return;
            }
            using(var kontekst = new WarsztatBD())
            {
                try
                {
                    var dostawca = kontekst.Dostawcy.Where(d => d.Id == a).First();
                    if (!nazwa.Text.IsNullOrEmpty()) dostawca.Nazwa = nazwa.Text;
                    if (!email.Text.IsNullOrEmpty()) dostawca.Email = email.Text;
                    if (b != 0) dostawca.Telefon = b;
                }
                catch (Exception)
                {
                    komunikat.Text = "Nie ma takiego dostawcy";
                    return;
                }
                try
                {
                    await kontekst.SaveChangesAsync();
                }
                catch (Exception)
                {
                    komunikat.Text = "Dostawca o podanej nazwie już istnieje w bazie danych";
                    return;
                }
                komunikat.Text = "Pomyślnie zmieniono dane dostawcy";
            }
        }

        private void nazwa_TextChanged(object sender, EventArgs e)
        {
            komunikat.Text = "";
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            komunikat.Text = "";
        }

        private void telefon_TextChanged(object sender, EventArgs e)
        {
            komunikat.Text = "";
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            komunikat.Text = "";
        }
    }
}
