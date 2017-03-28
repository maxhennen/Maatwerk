using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Atleten
{
    public class Blessure
    {
        public string Omschrijving { get; private set; }
        public string Lichaamsdeel { get; private set; }
        public DateTime Datum { get; private set; }

        public Blessure(string omschrijving, string lichaamsdeel, DateTime datum)
        {
            Omschrijving = omschrijving;
            Lichaamsdeel = lichaamsdeel;
            Datum = datum;
        }

        public override string ToString()
        {
            return Omschrijving + " " + Lichaamsdeel + " " + Datum;
        }
    }
}
