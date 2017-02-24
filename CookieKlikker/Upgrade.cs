using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieKlikker
{
    public class Upgrade
    {
        public string Naam { get; private set; }
        public int Kps { get; private set; }
        public int Prijs { get; private set; }
        public int PrijsInterval { get; private set; }
        public int Aantal { get; private set; }

        public Upgrade(string naam, int kps, int prijs, int prijsinterval)
        {
            Naam = naam;
            Kps = kps;
            Prijs = prijs;
            PrijsInterval = prijsinterval;
        }
    }
}
