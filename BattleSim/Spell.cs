using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    public class Spell
    {
        private string Naam;
        private int Power;
        private int ManaCost;

        public Spell(string naam, int power, int manaCost)
        {
            Naam = naam;
            Power = power;
            ManaCost = manaCost;
        }
    }
}
