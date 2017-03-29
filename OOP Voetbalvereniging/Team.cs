using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Voetbalvereniging
{
    [Serializable]
    public class Team:IComparable<Team>
    {
        public string Naam { get; private set; }
        public List<Wedstrijd> Wedstrijden { get; private set; }

        public Team(string naam)
        {
            Naam = naam;
        }
        public void NieuweWedstrijd(Wedstrijd wedstrijd)
        {
            if (wedstrijd.TeamThuis == wedstrijd.TeamUit)
            {
                throw new OngeldigeWedstrijdException("Uit en thuis team kunnen niet hetzelfde zijn");
            }
        }

        public int Behaaldpunten()
        {
            return 0;
        }

        public override string ToString()
        {
            return Naam;
        }

        public int CompareTo(Team other)
        {
            return this.Naam.CompareTo(other.Naam);
        }
    }
}
