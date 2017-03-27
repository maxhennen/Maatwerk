using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Concertkaartjes
{
    public class Concert
    {
        public string Artiest  { get; private set; }
        public DateTime Datum { get; private set; }
        public double Prijs { get; private set; }
        public string ConcertInfo { get; private set; }

        public Concert(string artiest, DateTime datum, double prijs)
        {
            Artiest = artiest;
            Datum = datum;
            Prijs = prijs;
            ConcertInfo = artiest + " - " + "Datum: " + datum.ToShortDateString() + " - " + prijs.ToString("c");
        }

        public class SorteerOpArtiest : IComparer<Concert>
        {
            public int Compare(Concert x, Concert y)
            {
                return x.Artiest.CompareTo(y.Artiest);
            }
        }

        public class SorteerOpPrijs : IComparer<Concert>
        {
            public int Compare(Concert x, Concert y)
            {
                return x.Prijs.CompareTo(y.Prijs);
            }
        }

        public class SorteerOpDatum : IComparer<Concert>
        {
            public int Compare(Concert x, Concert y)
            {
                return x.Datum.CompareTo(y.Datum);
            }
        }
    }

}
