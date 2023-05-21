using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warsztat_samochodowy.Okienka.OkienkaDostawcy;
using Warsztat_samochodowy.Okienka.OkienkaPracownicy;
using Warsztat_samochodowy.Okienka.OkienkaZlecenia;

//Wszelkie zdarzenia są wstawione trochę 'na siłę' po to aby pokazać zastosowanie tego typu rozwiązań w projekcie

namespace Warsztat_samochodowy.Zdarzenia
{
    internal class MenedzerZdarzen
    {
        public delegate void startProgramuHandler(object o, DatyEventArgs e);
        public delegate void startProgramuHandler2(object o, ZlecenieEventArgs e);

        public event startProgramuHandler? startProgramu;
        public event startProgramuHandler2? startProgramu2;
        protected virtual void publisherSprawdzoneTerminy(List<Rekordy.Zamowienie> wysylaneZamowienia, List<Rekordy.Zlecenie> wysylaneZlecenia)
        {
            startProgramu!(this, new DatyEventArgs() { wysylaneZamowienia = wysylaneZamowienia, wysylaneZlecenia = wysylaneZlecenia }) ;
        }

        protected virtual void publisherZmianaStatusu(Rekordy.Zlecenie zlecenie)
        {
            startProgramu2!(this, new ZlecenieEventArgs() { zlecenie = zlecenie });
        }

        public void sprawdzTerminy()
        {
            bool czyWywolywac = false;
            using (var kontekst = new KomunikacjaZBD())
            {
                IQueryable<Rekordy.Zamowienie> zamowienia = kontekst.zamowienia;
                List<Rekordy.Zamowienie> wysylaneZamowienia = new();

                IQueryable<Rekordy.Zlecenie> zlecenia = kontekst.zlecenia;
                List<Rekordy.Zlecenie> wysylaneZlecenia = new();

                foreach (var za in zamowienia)
                {
                    if ((DateTime.Compare(DateTime.Parse(za.kiedyDotrze!) , DateTime.Now.AddDays(7))<0) &&
                        (DateTime.Compare(DateTime.Parse(za.kiedyDotrze!), DateTime.Now.AddDays(-1)) > 0)) {
                        wysylaneZamowienia.Add(za);
                        czyWywolywac = true;                        
                    }
                }
                foreach(var zl in zlecenia)
                {
                    if (DateTime.Compare(DateTime.Today , DateTime.Parse(zl.dataWykonania!)) == 0 )
                    {
                        if(!zl.zakonczone)publisherZmianaStatusu(zl);
                    }
                    if (DateTime.Compare(DateTime.Parse(zl.dataWykonania!), DateTime.Now.AddDays(7)) < 0)
                    {
                        if (!zl.zakonczone)
                        {
                            wysylaneZlecenia.Add(zl);
                            czyWywolywac = true;
                        }

                    }
                }
                if (czyWywolywac) publisherSprawdzoneTerminy(wysylaneZamowienia, wysylaneZlecenia);
            }

        }
    }
}
