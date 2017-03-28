using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Atleten
{
    public class Schoen
    {
        public int AantalKm { get; private set; }
        public bool InGebruik { get; private set; }
        public string MerkEnType { get; private set; }

        public Schoen(int aantalKm, bool inGebruik, string merkEnType)
        {
            AantalKm = aantalKm;
            InGebruik = inGebruik;
            MerkEnType = merkEnType;
        }

        public void AantalKmOptellen(int km)
        {
            AantalKm += km;
        }

        public override string ToString()
        {
            return MerkEnType + " " + InGebruik + " " + AantalKm;
        }
    }
}
