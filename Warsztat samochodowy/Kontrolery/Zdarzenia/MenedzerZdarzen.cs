//Wszelkie zdarzenia są wstawione trochę 'na siłę' po to aby pokazać zastosowanie tego typu rozwiązań w projekcie

using Warsztat_samochodowy.Modele;

namespace Warsztat_samochodowy.Kontrolery.Zdarzenia
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
            using (var kontekst = new KomunikacjaZBD())
            {
                IQueryable<Zamowienie> zamowienia = kontekst.zamowienia;
                List<Zamowienie> wysylaneZamowienia = new();

                IQueryable<Zlecenie> zlecenia = kontekst.zlecenia;
                List<Zlecenie> wysylaneZlecenia = new();

                foreach (var za in zamowienia)
                {
                    if (DateTime.Compare(DateTime.Parse(za.kiedyDotrze!), DateTime.Now.AddDays(7)) < 0 &&
                        DateTime.Compare(DateTime.Parse(za.kiedyDotrze!), DateTime.Now.AddDays(-1)) > 0)
                    {
                        wysylaneZamowienia.Add(za);
                        czyWywolywac = true;
                    }
                }
                foreach (var zl in zlecenia)
                {
                    if (DateTime.Compare(DateTime.Today, DateTime.Parse(zl.dataWykonania!)) == 0)
                    {
                        if (!zl.zakonczone) publisherZmianaStatusu(zl);
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
