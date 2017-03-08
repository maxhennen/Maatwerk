using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakkerijGoedGeSpelt
{
    public class Broodje
    {
        public string Naam { get; private set; }
        private double Prijs;
        private string NaamEnPrijs;

        public Broodje(string naam, Broodsoort boord)
        {
            Naam = naam;
        }

        public bool BelegdBroodje(Beleg beleg, bool meerdan5)
        {
            return false;
        }
    }
}
