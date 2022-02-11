
using Day07CL;
using System;
using System.Collections.Generic;

namespace Day07
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            Car myRide = new Car();//create a new instance
            Car batmobile = new Car(10000);//create a DIFFERENT instance
            //batmobile.Odomoter = 10000;

            myRide.Odomoter = 100000; //calls the SET on my property
            int reading = myRide.Odomoter;//calls the GET
            Console.WriteLine($"My odometer reading: {myRide.Odomoter}");//calls the GET

            Console.WriteLine(batmobile.CarInfo());

            Console.WriteLine(Car.NumberOfCarsBuilt);

            Inventory backpack = new Inventory(5,new List<string>() { "wooden sword" });
            try
            {
                backpack.AddItem("rusty knife");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Backpack is full. Drop something!" + ex.Message);
            }
        }
    }
}
