using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace Day03
{
    enum WeaponType
    {
        Sword, Axe, Bow, Staff, Fists
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo ci = new CultureInfo("de-De");
            //Thread.CurrentThread.CurrentCulture = ci;
            //Thread.CurrentThread.CurrentUICulture = ci;

            WeaponType weapon = WeaponType.Fists;
            Dictionary<WeaponType, int> inventory = new Dictionary<WeaponType, int>();
            Dictionary<string, List<string>> wordDictionary = new Dictionary<string, List<string>>();

            Dictionary<string, float> menu = new Dictionary<string, float>() {
                {"Hamburger", 0.99F }, //key,value Pair
                {"Cheeseburger", 1.50F }
            };

            //Add method
            menu.Add("Fries", 0.99F);
            menu.Add("Soda", 0.99F);
            try
            {
                menu.Add("Soda", 0.99F);//will throw an exception
            }
            catch (Exception)
            {
                Console.WriteLine("Soda was already on the menu!");
            }

            bool isRemoved = menu.Remove("Chicken Nuggets");

            //[ ] -- add or update
            //if nuggets is NOT in the dictionary, it will add it ELSE it will update it
            menu["Chicken Nuggets"] = 2F;

            string offMenu = "hash browns";
            bool foundKey = menu.TryGetValue(offMenu, out float cost);
            if(foundKey) Console.WriteLine($"{offMenu} Price: {cost}");
            else
            {
                Console.WriteLine("That is not on the menu Karen.");
            }

            bool found = menu.ContainsKey("Chocolate Shake");
            if (found) Console.WriteLine("Chocolate shake is on the menu.");

            float menuPrice = menu["Hamburger"];

            menu["Hamburger"] = 4.99F;

            #region Challenge #1
            Dictionary<string, double> pg2 = new Dictionary<string, double>();
            pg2.Add("Clearence", GetGrade());
            pg2.Add("Casey", GetGrade());
            pg2.Add("Ethan", GetGrade());
            pg2.Add("Ulyssa", GetGrade());
            pg2.Add("Michael", GetGrade());
            pg2.Add("Nicolas", GetGrade());
            pg2.Add("Gabriel", GetGrade());
            pg2.Add("Teresa", GetGrade());
            pg2.Add("Zachary", GetGrade());
            #endregion

            //print the menu
            Console.WriteLine("Welcome to Burgerland.");
            foreach (KeyValuePair<string, float> menuItem in menu)
            {
                Console.WriteLine($"{menuItem.Key}: {menuItem.Value:C2}");
            }

            PrintGrades(pg2);

            #region Remove Challenge
            DropStudent(pg2);
            PrintGrades(pg2);
            #endregion

            #region TryGetValue
            CurveStudent(pg2);
            PrintGrades(pg2);
            #endregion
        }
        static void CurveStudent(Dictionary<string, double> grades)
        {
            Console.WriteLine("--------CURVING----------");
            //get student name
            Console.Write("Please enter a student name to curve: ");
            string name = Console.ReadLine();
            if(grades.TryGetValue(name, out double grade))
                grades[name] = grade + 5;
            else
                Console.WriteLine($"{name} is not in the class.");
        }
        static void DropStudent(Dictionary<string, double> grades)
        {
            Console.WriteLine("--------DROPPING----------");
            //get student name
            Console.Write("Please enter a student name to drop: ");
            string name = Console.ReadLine();
            bool wasRemoved = grades.Remove(name);
            if(wasRemoved)
                Console.WriteLine($"{name} was dropped from the class.");
            else
                Console.WriteLine($"{name} was not in the class.");
        }
        static void PrintGrades(Dictionary<string, double> grades)
        {
            Console.WriteLine("-----------GRADES--------");
            foreach (var grade in grades)
            {
                Console.Write($"{grade.Key,-15}");

                //if (grade.Value < 59.5)
                //    Console.BackgroundColor = ConsoleColor.DarkRed;
                //else if(grade.Value < 70)
                //    Console.BackgroundColor = ConsoleColor.Red;
                //else if (grade.Value < 80)
                //    Console.BackgroundColor = ConsoleColor.Yellow;
                //else if (grade.Value < 90)
                //    Console.BackgroundColor = ConsoleColor.Blue;
                //else
                //    Console.BackgroundColor = ConsoleColor.Green;
                //OR use a ternary operator
                Console.BackgroundColor = (grade.Value < 59.5) ? ConsoleColor.DarkRed :
                                          (grade.Value < 70) ? ConsoleColor.Red :
                                          (grade.Value < 80) ? ConsoleColor.Yellow :
                                          (grade.Value < 90) ? ConsoleColor.Blue :
                                          ConsoleColor.Green;

                Console.WriteLine($"{grade.Value,7:N2}");

                Console.ResetColor();
            }
        }

        static Random randy = new Random();
        static double GetGrade()
        {
            return randy.NextDouble() * 100;
        }
    }
}
