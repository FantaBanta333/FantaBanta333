using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day07CL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL.Tests
{
    [TestClass()]
    public class FantasyWeaponTests
    {
        [TestMethod()]
        public void FantasyWeaponTest()
        {
            //test that the constructor is working correctly (meaning, setting the properties correctly)
            FantasyWeapon fw = new FantasyWeapon(WeaponRarity.Legendary, 25, 1000, 100000);

            Assert.AreEqual(WeaponRarity.Legendary, fw.Rarity);
            Assert.AreEqual(25, fw.Level);
            Assert.AreEqual(1000, fw.MaxDamage);
            Assert.AreEqual(100000, fw.Cost);
        }
    }
}