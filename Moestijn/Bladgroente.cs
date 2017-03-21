using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moestijn
{
    public class Bladgroente : Groente
    {
        public Bladgroente(string naam) : base(naam)
        {
        }
        public Bladgroente(string naam, Maand zaaitijd, Maand oogsttijd) : base(naam, zaaitijd, oogsttijd)
        {
        }
    }
}
