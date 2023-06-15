using Warsztat_samochodowy.Modele;

namespace Warsztat_samochodowy.Kontrolery.Zdarzenia
{
    internal class ZlecenieEventArgs : EventArgs
    {
        public Zlecenie? zlecenie { get; set; }
    }

}
