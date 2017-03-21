using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceMan
{
    public class SpaceMan
    {
        private string naam;
        private int leeftijd;
        private List<Planeet> planetenBezocht;

        public string Naam { get { return naam; } }
        public int Leeftijd { get { return leeftijd; } }
        public List<Planeet> PlanetenBezocht { get { return planetenBezocht; } }

        public SpaceMan(string naam, int leeftijd)
        {
            this.naam = naam;
            this.leeftijd = leeftijd;
            planetenBezocht = new List<Planeet>();
        }

        public bool VoegBezochtePlaneetToe(Planeet planeet)
        {
            bool succes = true;

            foreach( Planeet p in planetenBezocht)
            {
                if (p.Naam == planeet.Naam)
                {
                    succes = false;
                }
            }

            if (succes)
            {
                planetenBezocht.Add(planeet);
            }
            return succes;
        }

        public List<Planeet> HaalBezochteBewoondePlaneten()
        {
            List<Planeet> bewoondePlaneten = new List<Planeet>();

            foreach (Planeet p in planetenBezocht)
            {
                if (p.Bewoond)
                {
                    bewoondePlaneten.Add(p);
                }
            }

            return bewoondePlaneten;
        }
    }
}
