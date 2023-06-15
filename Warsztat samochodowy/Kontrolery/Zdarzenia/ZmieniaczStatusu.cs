using Warsztat_samochodowy.Okienka.OkienkaZlecenia;

namespace Warsztat_samochodowy.Kontrolery.Zdarzenia
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
