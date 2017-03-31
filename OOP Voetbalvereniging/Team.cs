using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            try
            {
                if (wedstrijd.TeamThuis == wedstrijd.TeamUit || wedstrijd.DoelpuntenThuis < 0 ||wedstrijd.DoelpuntenUit < 0)
                {
                    throw new OngeldigeWedstrijdException("");
                }
                else
                {
                    wedstrijd.TeamThuis.Wedstrijden.Add(wedstrijd);
                    wedstrijd.TeamUit.Wedstrijden.Add(wedstrijd);
                }
            }
            catch (OngeldigeWedstrijdException)
            {
                MessageBox.Show("Uit en thuis team kunnen niet hetzelfde zijn of doelpunten kunnen niet negatieft zijn");
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
