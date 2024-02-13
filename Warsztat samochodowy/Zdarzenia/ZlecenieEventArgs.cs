using Warsztat.Model;

namespace Warsztat.Kontroler.Zdarzenia
{
    internal class ZlecenieEventArgs : EventArgs
    {
        public Zlecenie? zlecenie { get; set; }
    }

}
