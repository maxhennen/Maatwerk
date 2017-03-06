using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    public class Weapon
    {
        private string Naam;
        private int MaxHitDamage;

        public Weapon(string naam, int maxHitDamage)
        {
            Naam = naam;
            MaxHitDamage = maxHitDamage;
        }
    }
}
