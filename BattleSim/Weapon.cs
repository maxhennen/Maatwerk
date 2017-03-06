using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    public class Weapon
    {
        public string Naam { get; private set; }
        public int MaxHitDamage { get; private set; }

        public Weapon(string naam, int maxHitDamage)
        {
            Naam = naam;
            MaxHitDamage = maxHitDamage;
        }
    }
}
