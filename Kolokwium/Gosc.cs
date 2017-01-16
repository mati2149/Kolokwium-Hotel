using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Gosc
    {
        private string imie;
        private string nazwisko;

        public Gosc(string imie, string nazwisko) 
        { 
        this.nazwisko = nazwisko;
        this.imie = imie;
        }

        public override string ToString()
        {
            return "Gosc: " + imie + " " + nazwisko;
        }


    }
}
