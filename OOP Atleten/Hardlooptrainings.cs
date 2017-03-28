using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Atleten
{
    public class Hardlooptrainings:Training
    {
        public string Weertype { get; private set; }
        public Parcours Parcour { get; private set; }
        public Hardlooptrainings(DateTime tijdstips,int tijdsduur,int intensiteit,string omschrijving,string weertype,Parcours parcour):base(tijdstips,tijdsduur,intensiteit,omschrijving)
        {
            Weertype = weertype;
            Parcour = parcour;
        }

        public override string ToString()
        {
            return Tijdstip + " " + Intensiteit + " " + Tijdsduur + " " + Omschrijving + " " + Weertype;
        }
    }
}
