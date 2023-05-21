namespace Warsztat_samochodowy.Zdarzenia
{
    internal class DatyEventArgs: EventArgs
    {
        public List<Rekordy.Zamowienie> wysylaneZamowienia = new();
        public List<Rekordy.Zlecenie> wysylaneZlecenia = new();
    }
}
