using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moestijn
{
    public class Wortelgewas:Groente
    {
        public Wortelgewas(string naam) : base(naam)
        {
            
        }
        public Wortelgewas(string naam, Maand zaaitijd, Maand oogsttijd) : base(naam, zaaitijd, oogsttijd)
        {
        }
    }
}
