using Warsztat_samochodowy.Modele;

namespace Warsztat_samochodowy.Kontrolery.Zdarzenia
{
    internal class DatyEventArgs : EventArgs
    {
        public List<Zamowienie> wysylaneZamowienia = new();
        public List<Zlecenie> wysylaneZlecenia = new();
    }
}
