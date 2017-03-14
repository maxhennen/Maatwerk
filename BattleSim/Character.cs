using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    public abstract class Character
    {
        public string Naam { get; private set; }
        public int HitPoints { get; private set; }
        public Weapon EquipedWeapon { get; private set; }

        public Character(string naam, int hitPoints)
        {
            Naam = naam;
            HitPoints = hitPoints;
        }

        public int Hitpoints(int hitpoints)
        {
            HitPoints = hitpoints;
            return HitPoints;
        }

        public abstract int DealDamage();

        public abstract void ReceiveDamage(int damage);

        public void EquipWeapon(Weapon weapon)
        {
            EquipedWeapon = weapon;
        }
    }
}
