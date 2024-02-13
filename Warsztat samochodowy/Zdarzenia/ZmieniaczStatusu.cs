using Warsztat.Okienka.OkienkaZlecenia;

namespace Warsztat.Kontroler.Zdarzenia
{
    internal class ZmieniaczStatusu
    {
        public void zapytajOZmianeStatusu(object o, ZlecenieEventArgs e)
        {
            Thread.Sleep(3000);
            ZlecenieWykonano okienko = new();
            okienko.Show();
            okienko.zmienKomunikat(e.zlecenie!.Id);
        }
    }
}
