using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class BowWeapon : FantasyWeapon
    {
        public BowWeapon(int arrowCapacity, int arrowCount, WeaponRarity rarity, int level, int maxDamage, int cost) : base(rarity, level, maxDamage, cost)
        {
            ArrowCapacity = arrowCapacity;
            ArrowCount = arrowCount;
        }

        public int ArrowCapacity { get; private set; }
        public int ArrowCount { get; private set; }
    }
}
