using System;

namespace Splitting_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "12,45,776,876,543";
            string[] numberStrings = data.Split(',');
            for (int i = 0; i < numberStrings.Length; i++)
            {
                Console.WriteLine(numberStrings[i]);
            }



            string names = "Joker,Riddler,Catwoman,Twoface,Bane";
            Console.WriteLine("-------Vilians------");
            string[] arkhamNutjobs = names.Split(',');
            for (int i = 0; i < arkhamNutjobs.Length; i++)
            {
                Console.WriteLine(arkhamNutjobs[i]);
            }

            string multiples = "15-43---96_Student1_Student2__Student5";
            Console.WriteLine("---------Grades--------");
            char[] delimiters = new char[] { '-', '_' };
            string[] grades = multiples.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }
        }
    }
}
