using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public static class Input
    {
        public static int ReadInteger(string prompt, int min, int max)
        {
            int number = 0;
            do
            {
                Console.Write(prompt);

                if (int.TryParse(Console.ReadLine(), out number) && number >= min && number <= max)
                    return number;

                Console.WriteLine("That is not a valid number. Please try again.");
            } while (true);
        }

        public static void ReadString(string prompt, ref string value)
        {
            do
            {
                Console.Write(prompt);
                value = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(value))
                    break;
                Console.WriteLine("That is not a valid string. Please try again.");
            } while (true);
        }

        public static void ReadChoice(string prompt, List<string> options, out int selection)
        {
            foreach (var item in options)
                Console.WriteLine(item);

            selection = ReadInteger(prompt, 1, options.Count);
        }
    }
}
