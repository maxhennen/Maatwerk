using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceMan
{
    public class Planeet
    {
        private string naam;
        private bool bewoond;
        private DateTime aangekomen;
        private DateTime vertrek;

        public string Naam { get { return naam; } }
        public bool Bewoond { get { return bewoond; } }
        public DateTime Aangekomen { get { return aangekomen; } }
        public DateTime Vertrek { get { return vertrek; } }

        public Planeet(string naam, bool bewoond,DateTime aangekomen,DateTime vertrek)
        {
            this.naam = naam;
            this.bewoond = bewoond;
            this.aangekomen = aangekomen;
            this.vertrek = vertrek;
        }
    }
}
