using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class FantasyWeapon : IWeapon
    {
        public WeaponRarity Rarity { get; set; }
        public int Level { get; set; }
        public int MaxDamage { get; set; }
        public int Cost { get; set; }

        private static Random _randy = new Random();

        public int DoDamage() //hidden "this" parameter. this is the object used. EX: sting
        {
            return (int)(MaxDamage * _randy.NextDouble());
        }
        /// <summary>
        /// Calculates the damage for the weapon with an enchantment added.
        /// </summary>
        /// <param name="enchantment">The amount to add to the max damage for the weapon.</param>
        /// <returns>The damage that the weapon does.</returns>
        public int DoDamage(int enchantment) 
        {
            return (int)((MaxDamage + enchantment) * _randy.NextDouble());
        }

        public virtual void Display()
        {
            Console.WriteLine($"------Weapon Info-------\nRarity: {Rarity} Level: {Level} Max Damage: {MaxDamage} Cost: {Cost}");
        }

        public FantasyWeapon(WeaponRarity rarity, int level, int maxDamage, int cost)
        {
            Rarity = rarity;
            Level = level;
            MaxDamage = maxDamage;
            Cost = cost;
        }
    }
}
