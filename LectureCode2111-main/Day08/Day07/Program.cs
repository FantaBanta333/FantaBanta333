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
            Car myRide = new Car(0);//create a new instance
            Car batmobile = new Car(10000);//create a DIFFERENT instance
            //batmobile.Odomoter = 10000;

            myRide = new Truck(10000, 100, 2020, "Tesla", "CyberTruck"); //upcasting
            myRide = batmobile;
            //DOWNCASTING...
            //doable but not the best
            try
            {
                Truck t150 = (Truck)myRide;//downcasting. NOT SAFE!
            }
            catch (Exception)
            {
            }
            //better way
            Truck t250 = myRide as Truck;//will set t250 to null if myRide is NOT a truck
            if(t250 != null)
            {
                //do something with t250
            }

            //best way. pattern matching
            if(myRide is Truck t350)
            {                
                //do something with t250
            }

            myRide.Odomoter = 100000; //calls the SET on my property
            int reading = myRide.Odomoter;//calls the GET
            Console.WriteLine($"My odometer reading: {myRide.Odomoter}");//calls the GET

            Console.WriteLine(batmobile.CarInfo());

            Console.WriteLine(Car.NumberOfCarsBuilt);

            Inventory backpack = new Inventory(5,new List<FantasyWeapon>() { (FantasyWeapon)WeaponFactory.CreateWeapon(WeaponRarity.Common, 1, 10, 20) });
            try
            {
                backpack.AddItem((FantasyWeapon)WeaponFactory.CreateWeapon(WeaponRarity.Common, 1, 5, 10));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Backpack is full. Drop something!" + ex.Message);
            }

            //upcasting
            backpack.AddItem(new BowWeapon(10, 5, WeaponRarity.Uncommon, 5, 50, 1000));

            FantasyWeapon sting = new FantasyWeapon(WeaponRarity.Rare, 5, 100, 100000);
            Console.WriteLine($"Sting does {sting.DoDamage()}");

            IWeapon sword = WeaponFactory.CreateWeapon(WeaponRarity.Common, 1, 10, 100);

            Console.WriteLine("----------BACKPACK-----------");
            backpack.PrintInventory();
        }
    }
}
