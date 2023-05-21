namespace Warsztat_samochodowy.Zdarzenia
{
    internal class ZlecenieEventArgs : EventArgs
    {
        public Rekordy.Zlecenie? zlecenie { get; set; }
    }

}
