﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace BakkerijGoedGeSpelt
{
    [Serializable]
    public class Broodje
    {
        public string Naam { get; private set; }
        public double Prijs { get; private set; }
        public string NaamEnPrijs { get; private set; }

        public Broodje(string naam, BelegSoort belegSoort)
        {
            Naam = naam;
        }

       //public bool BelegBroodje(Beleg beleg, out bool meerdan5)
       //{
       //    return true;
       //}

        
        public string NaamPrijs(string naam, double prijs)
        {
            NaamEnPrijs = naam + " - " + prijs;
            return NaamEnPrijs;
        }
    }
}
