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
    public class BowWeaponTests
    {
        [TestMethod()]
        public void BowWeaponTest()
        {
            BowWeapon bow = new BowWeapon(10, 5, WeaponRarity.Uncommon, 5, 50, 1000);

            Assert.AreEqual(WeaponRarity.Uncommon, bow.Rarity);
            Assert.AreEqual(5, bow.Level);
            Assert.AreEqual(50, bow.MaxDamage);
            Assert.AreEqual(1000, bow.Cost);

            Assert.AreEqual(10, bow.ArrowCapacity);
            Assert.AreEqual(5, bow.ArrowCount);
        }
    }
}