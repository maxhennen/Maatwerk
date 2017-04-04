using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Voetbalvereniging
{
    public class Team:IComparable<Team>
    {
        public string Naam { get; private set; }
        public List<Wedstrijd> Wedstrijden { get; private set; }

        public Team(string naam)
        {
            Naam = naam;
            Wedstrijden = new List<Wedstrijd>();
        }
        public void NieuweWedstrijd(Wedstrijd wedstrijd)
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

        public int Behaaldpunten()
        {
            int behaaldePunten = 0;
            foreach (Wedstrijd W in Wedstrijden)
            {
                if (W.GetType() == typeof(CompetitieWedstrijd))
                {
                    if (W.TeamThuis.Naam == Naam)
                    {
                        if (W.DoelpuntenThuis > W.DoelpuntenUit)
                        {
                            behaaldePunten += 3;
                        }

                        else if (W.DoelpuntenThuis == W.DoelpuntenUit)
                        {
                            behaaldePunten += 1;
                        }
                    }

                    if (W.TeamUit.Naam == Naam)
                    {
                        if (W.DoelpuntenThuis < W.DoelpuntenUit)
                        {
                            behaaldePunten += 3;
                        }
                        else if (W.DoelpuntenThuis == W.DoelpuntenUit)
                        {
                            behaaldePunten += 1;
                        }
                    }
                }
            }
            return behaaldePunten;
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
