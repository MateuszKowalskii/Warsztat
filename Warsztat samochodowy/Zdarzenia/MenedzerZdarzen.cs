//Wszelkie zdarzenia są wstawione trochę 'na siłę' po to aby pokazać zastosowanie tego typu rozwiązań w projekcie

using Warsztat.Model;

namespace Warsztat.Kontroler.Zdarzenia
{
    internal class MenedzerZdarzen
    {
        public delegate void wTymTygodniuHandler(object o, DatyEventArgs e);
        public delegate void aktualizacjaZlecenHandler(object o, ZlecenieEventArgs e);

        public event wTymTygodniuHandler? wTymTygodniu;
        public event aktualizacjaZlecenHandler? aktualizacjaZlecen;
        protected virtual void publisherSprawdzoneTerminy(List<Zamowienie> wysylaneZamowienia, List<Zlecenie> wysylaneZlecenia)
        {
            wTymTygodniu!(this, new DatyEventArgs() { wysylaneZamowienia = wysylaneZamowienia, wysylaneZlecenia = wysylaneZlecenia });
        }

        protected virtual void publisherZmianaStatusu(Zlecenie zlecenie)
        {
            aktualizacjaZlecen!(this, new ZlecenieEventArgs() { zlecenie = zlecenie });
        }

        public void sprawdzTerminy()
        {
            bool czyWywolywac = false;
            using (var kontekst = new WarsztatBD())
            {
                IQueryable<Zamowienie> zamowienia = kontekst.Zamowienia;
                List<Zamowienie> wysylaneZamowienia = new();

                IQueryable<Zlecenie> zlecenia = kontekst.Zlecenia;
                List<Zlecenie> wysylaneZlecenia = new();

                foreach (var za in zamowienia)
                {
                    if (DateTime.Compare(DateTime.Parse(za.KiedyDotrze!), DateTime.Now.AddDays(7)) < 0 &&
                        DateTime.Compare(DateTime.Parse(za.KiedyDotrze!), DateTime.Now.AddDays(-1)) > 0)
                    {
                        wysylaneZamowienia.Add(za);
                        czyWywolywac = true;
                    }
                }
                foreach (var zl in zlecenia)
                {
                    if (DateTime.Compare(DateTime.Today, DateTime.Parse(zl.DataWykonania!)) == 0)
                    {
                        if (!zl.Zakonczone) publisherZmianaStatusu(zl);
                    }
                    if (DateTime.Compare(DateTime.Parse(zl.DataWykonania!), DateTime.Now.AddDays(7)) < 0)
                    {
                        if (!zl.Zakonczone)
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
