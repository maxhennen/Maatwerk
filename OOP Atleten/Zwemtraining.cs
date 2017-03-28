using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Atleten
{
    public class Zwemtraining:Training
    {
        public string Slag { get; private set; }
        public bool Indoor { get; private set; }
        public int AantalMeter { get; private set; }

        public Zwemtraining(DateTime tijdstip, int tijdsduur, int intensiteit, string omschrijving, string slag,
            bool indoor, int aantalMeter) : base(tijdstip, tijdsduur, intensiteit, omschrijving)
        {
            Slag = slag;
            Indoor = indoor;
            AantalMeter = aantalMeter;
        }

        public override string ToString()
        {
            return Tijdstip + " " + Tijdsduur + " " + Intensiteit + " " + Omschrijving + " " + Slag + " " + Indoor + " " +
                   AantalMeter;
        }
    }
}
