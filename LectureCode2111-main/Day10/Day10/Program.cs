using System;

namespace Day10
{
    enum Powers
    {
        Strength, Money, Flight, Swimming
    }
    class Program
    {
        static void Main(string[] args)
        {
            Powers myPower = Powers.Money;
            switch (myPower)
            {
                case Powers.Strength:
                case Powers.Money:
                case Powers.Flight:
                    Console.WriteLine("The best ones.");
                    break;
                case Powers.Swimming:
                    Console.WriteLine("WEAK!");
                    break;
                default:
                    break;
            }
        }
    }
}
