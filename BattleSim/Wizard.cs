using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    public class Wizard:Character
    {
        public int Mana { get; private set; }
        public Spell Spell = new Spell("Spreak",10,10);
        public Weapon Weapon = new Weapon("Sword", 10);

        public Wizard(string naam, int hitpoints) : base(naam, hitpoints)
        {
            
        }

        public override int DealDamage()
        {
            if (Mana >= Spell.ManaCost)
            {
                return Spell.Power;
            }

            else
            {
                Random r = new Random();
                int damage = r.Next(0, Weapon.MaxHitDamage);
                return damage;
            }
        }

        public override void ReceiveDamage(int damage)
        {
            int hitpoints = HitPoints - damage;
            Character c = new Wizard(this.Naam,hitpoints);
        }
    }
}
