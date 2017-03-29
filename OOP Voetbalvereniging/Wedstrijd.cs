using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Voetbalvereniging
{
    public abstract class Wedstrijd
    {
        public Team TeamThuis { get; private set; }
        public Team TeamUit { get; private set; }
        public int DoelpuntenThuis { get; private set; }
        public int DoelpuntenUit { get; private set; }
        public List<Wedstrijd> Wedstrijden { get; private set; }

        public Wedstrijd(Team teamThuis, Team teamUit, int doelpuntenThuis, int doelpuntenUit)
        {
            TeamThuis = teamThuis;
            TeamUit = teamUit;
            DoelpuntenThuis = doelpuntenThuis;
            DoelpuntenUit = doelpuntenUit;
            Wedstrijden = new List<Wedstrijd>();
        }

        public override string ToString()
        {
            return TeamThuis.Naam + " - " + TeamUit.Naam + "is geeindigd in " + DoelpuntenThuis + " - " + DoelpuntenUit;
        }
    }
}
