using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warsztat_samochodowy.Zdarzenia
{
    internal class ZlecenieEventArgs : EventArgs
    {
        public Rekordy.Zlecenie? zlecenie { get; set; }
    }

}
