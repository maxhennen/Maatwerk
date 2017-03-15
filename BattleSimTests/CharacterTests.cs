using Microsoft.VisualStudio.TestTools.UnitTesting;
using BattleSim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim.Tests
{
    [TestClass()]
    public class CharacterTests
    {
        [TestMethod()]
        public void DealDamageTest()
        {
            Knight knight = new Knight("Knight", 10);
            Wizard wizard = new Wizard("Wizard", 10);
            int damageWizard = 0;

            if (wizard.Mana >= wizard.Spell.ManaCost)
            {
           
            }

            else
            {
                Random Wr = new Random();
                damageWizard = Wr.Next(0, wizard.EquipedWeapon.MaxHitDamage);
            }
            Assert.IsTrue(damageWizard >= 0 && damageWizard <= wizard.Weapon.MaxHitDamage, "Goed");

            Random Kr = new Random();
            int damageKnight = Kr.Next(0, knight.EquipedWeapon.MaxHitDamage);
            Assert.IsTrue(damageKnight >= 0 && damageKnight <= knight.Weapon.MaxHitDamage, "Goed");
        }
        
        [TestMethod()]
        public void ReceiveDamageTest()
        {
            Knight knight = new Knight("Knight", 10);
            Character wizard = new Wizard("Wizard", 10);

            int damage = 10;
            int KnightHitpoints = 0;
            damage = damage - knight.ShieldPower;
            if (damage >= 0)
            {
                KnightHitpoints = knight.HitPoints - damage;
                knight.Hitpoints(KnightHitpoints);
            }
            Knight knight1 = new Knight("Knight", KnightHitpoints);
            Assert.Equals(knight1, knight);
            knight.Equals(knight1);
            Assert.AreEqual(0, knight.HitPoints);

            int WizardHitpoints = wizard.HitPoints - damage;
            wizard.Hitpoints(WizardHitpoints);

            Assert.AreEqual(0,wizard.HitPoints);
        }
    }
}