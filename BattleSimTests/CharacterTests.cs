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
            Character knight = new Knight("Knight", 10);
            Wizard wizard = new Wizard("Wizard", 10);


            if (wizard.Mana >= wizard.Spell.ManaCost)
            {
                int damage = wizard.Spell.ManaCost;
                Assert.AreEqual(1,damage);
            }
        }
        
        [TestMethod()]
        public void ReceiveDamageTest()
        {
            Knight knight = new Knight("Knight", 10);
            Character wizard = new Wizard("Wizard", 10);

            int damage = 10;

            damage = damage - knight.ShieldPower;
            if (damage >= 0)
            {
                int KnightHitpoints = knight.HitPoints - damage;
                knight.Hitpoints(KnightHitpoints);
            }
            Assert.AreEqual(0, knight.HitPoints);

            int WizardHitpoints = wizard.HitPoints - damage;
            wizard.Hitpoints(WizardHitpoints);

            Assert.AreEqual(0,wizard.HitPoints);
        }
    }
}