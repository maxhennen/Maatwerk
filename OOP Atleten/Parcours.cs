using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Atleten
{
    public class Parcours
    {
        public string Kaart { get; private set; }
        public string Beschrijving { get; private set; }
        public int SnelsteTijdMinuten { get; private set; }
        public int AfstandKm { get; private set; }
        public int MaxHoogteverschil { get; private set; }
        public bool Verhard { get; private set; }

        public Parcours(string kaart, string beschrijving, int snelsteTijdMinuten, int afstandKm, int maxHoogteverschil,
            bool verhard)
        {
            Kaart = kaart;
            Beschrijving = beschrijving;
            SnelsteTijdMinuten = snelsteTijdMinuten;
            AfstandKm = afstandKm;
            MaxHoogteverschil = maxHoogteverschil;
            Verhard = verhard;
        }

        public override string ToString()
        {
            return Beschrijving + " " + SnelsteTijdMinuten + " " + AfstandKm + " " + MaxHoogteverschil + " " + Verhard;
        }
    }
}
