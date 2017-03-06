using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    public class Spell
    {
        public string Naam { get; private set; }
        public int Power { get; private set; }
        public int ManaCost { get; private set; }

        public Spell(string naam, int power, int manaCost)
        {
            Naam = naam;
            Power = power;
            ManaCost = manaCost;
        }
    }
}
