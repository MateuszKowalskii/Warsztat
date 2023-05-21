namespace Warsztat_samochodowy.Zdarzenia
{
    internal class Informator
    {
        ListBox lista { get; set; }
        public Informator(ListBox lista)
        {
            this.lista = lista;
        } 
        public void informuj(object o, DatyEventArgs e)
        {
            foreach (Rekordy.Zamowienie zamowienie in e.wysylaneZamowienia)
            {
                lista.Items.Add(zamowienie.kiedyDotrze +" dotrze "+ zamowienie.ilosc.ToString()+" sztuk "+ zamowienie.nazwa);
            }
            foreach(Rekordy.Zlecenie zlecenie in e.wysylaneZlecenia)
            {
                lista.Items.Add(zlecenie.dataWykonania + " ma być zrealizowane zlecenie " + zlecenie.Id);
            }
        }

    }
}
