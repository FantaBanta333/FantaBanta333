using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Notes
    {
        static void Main(string[] args)
        {
            CreatingAndAdding();

        }

        private static void CreatingAndAdding()
        {
            Dictionary<string, float> menu = new Dictionary<string, float>() //Contains a 'Key' and a 'value'. Both, must consist of a type but do not have to match.
            {
                //{key, value}
                {"Hamburger", 6.99F },
                {"Cheesy Hamburger", 7.99F }
            };

            //Add(key, value)
            menu.Add("Fries", 0.99F);
            menu.Add("Soda", 0.99F);

            //[key] = value;
            menu["Chicken Nuggets"] = 5F;
            menu["Water"] = 0.50F;
            ShowMenu(menu);

            RemoveMenuItem("Chicken Nuggets", menu);
            RemoveMenuItem("Curly Fries", menu);
            ShowMenu(menu);
            CheckPrice(menu);
        }
        private static void CheckPrice(Dictionary<string, float> menu)
        {
            Console.Write("Item to check: ");
            string menuItem = Console.ReadLine();

            if (menu.ContainsKey(menuItem))
            {
                Console.WriteLine($"{menuItem} was found. It's price is {menu[menuItem]:C2}");
                menu[menuItem] += 0.50F; //the 'menu[menuItem]' must be on the left side of the fuction
            }                    //the '+= 0.50F' puts an increment on the price
            else
            {
                Console.WriteLine($"{menuItem} was not found.");
            }
            //OR
            if (menu.TryGetValue(menuItem, out float CheckPrice))
            {
                Console.WriteLine($"{menuItem} was found. It's price was {CheckPrice:C2}.");
            }
            else
            {
                Console.WriteLine($"{menuItem} was not found.");
            }
        }
        private static void RemoveMenuItem(string menuItem, Dictionary<string, float> menu)
        {
            //Removing from Dictionaries
            bool isRemoved = menu.Remove(menuItem);
            if (isRemoved)
                Console.WriteLine($"{menuItem} was removed.");
            else
                Console.WriteLine($"{menuItem} was not on the menu.");
        }
        private static void ShowMenu(Dictionary<string, float> menu)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------Menu-------------");
            foreach (var item in menu) //var is substituting 'KeyValuePair<string, float>
            {
                Console.ForegroundColor = ConsoleColor.Green; //makes the 'Key' items green
                Console.Write(item.Key);

                Console.CursorLeft = 17; //shifts all items to the right by 17 spaces
                Console.ForegroundColor = ConsoleColor.DarkCyan; //turns all 'Value' items DarkCyan
                Console.WriteLine($"{item.Value:C2}"); //'C2' refers to 'C' for currency and the '2' stands for two decimal places

            }
            Console.ResetColor(); // to not have the remaining program the previous color
        }


    }
}
