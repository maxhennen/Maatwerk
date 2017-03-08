using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakkerijGoedGeSpelt
{
    public class Brood
    {
        public string Beschrijving { get; private set; }
        public BelegSoort SoortBeleg { get; private set; }  
        public double Prijs { get; private set; }

        public Brood(string beschrijving, BelegSoort soortBeleg, double prijs)
        {
            Beschrijving = beschrijving;
            SoortBeleg = soortBeleg;
            Prijs = prijs;
        }
    }
}
