using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Hotel : IHotel, IData
    {
        private SortedList<Pokoj, Gosc> listaPokoi = new SortedList<Pokoj, Gosc>();
        private double zysk = -80;
        private DateTime data;

        public void UstawDate(DateTime Time)
        {
            data = Time;
        }
        public bool SprawdzDate()
        {
            if (DateTime.Compare(data, DateTime.Today) > 0)
                return true;
            else
                return false;
        }


        public void DodajRezerwacje(string imie, string nazwisko, int nr, double cena)
        {
            listaPokoi.Add(new Pokoj(nr, cena), new Gosc(imie, nazwisko));
            zysk += cena;
        }
        public void OdwołajRezerwacje()
        {
            if (listaPokoi.Count > 0) listaPokoi.RemoveAt(listaPokoi.Count - 1);
        }

        public override string ToString()
        {
            string wstep = "Rezerwacje: ";
            foreach (var element in listaPokoi)
            {
                wstep += Environment.NewLine + element.ToString();                        }
            return wstep + Environment.NewLine + "Data: " + data + Environment.NewLine + "Zysk: " + Convert.ToString(zysk);
        }



    }
}
