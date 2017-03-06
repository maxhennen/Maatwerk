using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    public abstract class Character
    {
        private string Naam;
        private int HitPoints;

        public Character(string naam, int hitPoints)
        {
            Naam = naam;
            HitPoints = hitPoints;
        }

        public int DealDamage()
        {
            
        }

        public void ReceiveDamage(int damage)
        {
            
        }

        public void EquipWeapon(Weapon weapon)
        {
            
        }
    }
}
