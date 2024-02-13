using Warsztat.Model;

namespace Warsztat.Kontroler.Zdarzenia
{
    internal class InformatorPowiadomien
    {
        ListBox listaPowiadomien { get; set; }
        public InformatorPowiadomien(ListBox lista)
        {
            listaPowiadomien = lista;
        }
        public void informuj(object o, DatyEventArgs e)
        {
            foreach (Zamowienie zamowienie in e.wysylaneZamowienia)
            {
                listaPowiadomien.Items.Add(zamowienie.KiedyDotrze + " dotrze " + zamowienie.Ilosc.ToString() + " sztuk " + zamowienie.Nazwa);
            }
            foreach (Zlecenie zlecenie in e.wysylaneZlecenia)
            {
                listaPowiadomien.Items.Add(zlecenie.DataWykonania + " ma być zrealizowane zlecenie " + zlecenie.Id);
            }
        }

    }
}
