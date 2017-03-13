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
            Character knight = new Knight("Knight",10);
            Character wizard = new Wizard("Wizard",10);


        }
    }
}