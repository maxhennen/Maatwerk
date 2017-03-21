using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moestijn
{
    public abstract class Groente
    {
        public string Naam { get; private set; }
        public Maand Zaaitijd { get; private set; }
        public Maand Oogsttijd { get; private set; }

        public Groente(string naam)
        {
            Naam = naam;
        }
        public Groente(string naam, Maand zaaitijd, Maand oogsttijd)
        {
            Naam = naam;
            Zaaitijd = zaaitijd;
            Oogsttijd = oogsttijd;
        }
    }
}
