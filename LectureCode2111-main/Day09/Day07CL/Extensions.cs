using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public static class Extensions
    {
        public static void Upgrade(this FantasyWeapon weapon, int levelUpgrade)
        {
            if(weapon.Level + levelUpgrade <= 50)
                weapon.Level += levelUpgrade;
        }

        public static List<BowWeapon> Bows(this Inventory inv)
        {
            List<BowWeapon> bows = new List<BowWeapon>();
            foreach (var item in inv.Items)
            {
                if (item is BowWeapon bow)
                    bows.Add(bow);
            }
            return bows;
        }
    }
}
