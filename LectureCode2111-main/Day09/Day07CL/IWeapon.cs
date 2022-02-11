using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public interface IWeapon
    {
        WeaponRarity Rarity { get; set; }
        int Level { get; set; }
        int MaxDamage { get; set; }
        int Cost { get; set; }

        int DoDamage();
    }
}
