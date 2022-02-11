using System;

namespace Day11b
{
    enum WeaponRarity
    {
        Common, Uncommon, Rare, Legendary
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int num = 5;
            string best = "Batman";

            Random rando = new Random();
            int[] nums = new int[5] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(rando.Next(1001));
                Console.WriteLine(nums[i]);
            }
        }
    }
}
