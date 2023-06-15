using Warsztat_samochodowy.Modele;

namespace Warsztat_samochodowy.Kontrolery.Zdarzenia
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
                listaPowiadomien.Items.Add(zamowienie.kiedyDotrze + " dotrze " + zamowienie.ilosc.ToString() + " sztuk " + zamowienie.nazwa);
            }
            foreach (Zlecenie zlecenie in e.wysylaneZlecenia)
            {
                listaPowiadomien.Items.Add(zlecenie.dataWykonania + " ma być zrealizowane zlecenie " + zlecenie.Id);
            }
        }

    }
}
