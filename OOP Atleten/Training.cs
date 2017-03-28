using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Atleten
{
    public abstract class Training : ITraining
    {
        public DateTime Tijdstip { get ; private set; }
        public int Tijdsduur { get; private set ; }
        public int Intensiteit { get; private set ; }
        public string Omschrijving { get; private set ; }
        public Training(DateTime tijdstip, int tijdsduur, int intensiteit, string omschrijving)
        {
            Tijdstip = tijdstip;
            Tijdsduur = tijdsduur;
            Intensiteit = intensiteit;
            Omschrijving = omschrijving;
        }

        public int CompareTo(Training other)
        {
            return this.Tijdstip.CompareTo(other.Tijdstip);
        }

        public class SorteerOpIntensiteitEnTijdsduur : IComparer<Training>
        {
            public int Compare(Training x, Training y)
            {
                int intensiteit =  x.Intensiteit.CompareTo(y.Intensiteit);
                if (intensiteit == 0)
                {
                    return x.Tijdsduur.CompareTo(y.Tijdsduur);
                }
                return intensiteit;
            }
        }

        public abstract string ToString();
    }
}
