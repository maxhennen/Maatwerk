using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moestijn
{
    public class Moestuin
    {
        public List<Groente> Groenten { get; private set; }
        public Moestuin()
        {
            
        }

        public void Vullijst()
        {
            Groenten = new List<Groente>();

            Groenten.Add(new Wortelgewas("Wortel",Maand.April, Maand.December));
            Groenten.Add(new Bladgroente("Sla",Maand.Augustus,Maand.Juli));
            Groenten.Add(new Bladgroente("Tomaat",Maand.Januari, Maand.Maart));
            Groenten.Add(new Wortelgewas("Komkommer",Maand.Augustus, Maand.Oktober));
            Groenten.Add(new Bladgroente("Andijvie",Maand.November,Maand.December));
            Groenten.Add(new Wortelgewas("Boerenkool",Maand.Oktober,Maand.November));
        }

        /// <summary>
        /// Deze methode zoekt groenten die van het gegeven type zijn
        /// en in de gegeven maand gezaaid kunnen worden.
        /// </summary>
        /// <param name="type">Het type groente, bijvoorbeeld "Bladgroente" als object</param>
        /// <param name="zaaitijd">De zaaitijd (Maand)</param>
        /// <returns>Geeft een lijst terug met groenten die van het gegeven type 
        /// zijn en in de gegeven maand gezaaid kunnen worden.</returns>

        public List<Groente> ZoekGroentes(object type, Maand zaaitijd)
        {
            List<Groente> GroentenZoeken;
            var obj = (from g in Groenten where g.GetType() == type where g.Zaaitijd == zaaitijd select new {g.Naam,g.Zaaitijd,g.Oogsttijd});
            return GroentenZoeken = obj as List<Groente>;
            
        }
    }
}
