using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    public class Knight : Character
    {
        private int ShieldPower;
        private Weapon Weapon = new Weapon("Sword", 10);


        public Knight(string naam, int hitPoints) : base(naam, hitPoints)
        {

        }

        public override int DealDamage()
        {
            Random r = new Random();
            int damage = r.Next(0, Weapon.MaxHitDamage);
            return damage;
        }

        public override void ReceiveDamage(int damage)
        {
            damage = damage - ShieldPower;
            if (damage >= 0)
            {
                int hitpoints = HitPoints - damage;
                Character c = new Knight(this.Naam,hitpoints);
            }
        }
    }
}
