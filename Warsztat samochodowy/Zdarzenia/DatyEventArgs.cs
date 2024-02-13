using Warsztat.Model;

namespace Warsztat.Kontroler.Zdarzenia
{
    internal class DatyEventArgs : EventArgs
    {
        public List<Zamowienie> wysylaneZamowienia = new();
        public List<Zlecenie> wysylaneZlecenia = new();
    }
}
