using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warsztat_samochodowy.Okienka.OkienkaZlecenia;

namespace Warsztat_samochodowy.Zdarzenia
{
    internal class ZmieniaczStatusu
    {
        public void zapytajOZmianeStatusu(object o, ZlecenieEventArgs e)
        {
            Thread.Sleep(3000);
            ZlecenieWykonano okienko = new();
            okienko.Show();
            okienko.zmienkomunikat(e.zlecenie!.Id);
        }
    }
}
