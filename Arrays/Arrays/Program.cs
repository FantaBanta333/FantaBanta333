using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ListChallenge();
            //ArrayChallenge();

        }    
        private static void ListChallenge()
        {
            List<double> grades = new List<double>(10); //adding the '10' cuts out extra work
            Random random = new Random();
            for (int i = 0; i < 10; i++) //we only needed 10 'grades' so change 'length' to 10
            {
                grades.Add(random.NextDouble() * 100); //adds the random number generator to the list and multiplies it by 100
                Console.WriteLine(grades[i]); //prints the grades from the list
            }
            PrintGrades(grades);
            int numberOfGradesRemoved = DropFailing(grades);
            Console.WriteLine($"{ numberOfGradesRemoved} number(s) have been dropped. ");

            PrintGrades(grades);
            Console.WriteLine("--------Curved Grades---------");
            List<double> curvedGrades = CurveGrade(grades);
            PrintGrades(curvedGrades);
        }
        private static int DropFailing(List<double> grades)
        {
            //loop and remove all grades < 59
            Console.WriteLine("-----------Drop Failing Grades----------");
            int numberRemoved = 0;
            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] < 59.5)
                {
                    grades.RemoveAt(i);
                    numberRemoved++;
                    i--; //force the currrent index to be re-evaluated
                }
            }
            //OR...use a reverse for loop
            for (int i = grades.Count - 1; i >= 0; i--)
            {
                if (grades[i] < 59.5)
                {
                    grades.RemoveAt(i); //shift all items after it
                    numberRemoved++;
                }
            }
            return numberRemoved;
        }
        
        private static List<double> CurveGrade(List<double> grades)
        {
            List<double> curved = grades.ToList();
            for (int i = 0; i < curved.Count; i++)
            {
                curved[i] += 5;
                if(curved[i] > 100) curved[i] = 100;
            }
            return curved;
        }
        private static void PrintGrades(List<double> grades)
        {
            Console.WriteLine("--------Grades-------");
            for (int i = 0; i < grades.Count; i++) //when looping over, make sure to use the 'Count'
            { //ternary operator --> '?' <--
                Console.ForegroundColor = (grades[i] > 89) ? ConsoleColor.Green :
                                          (grades[i] > 79) ? ConsoleColor.DarkCyan :
                                          (grades[i] > 69) ? ConsoleColor.Yellow :
                                          (grades[i] > 59) ? ConsoleColor.DarkYellow :
                                          ConsoleColor.Red;
                Console.WriteLine($"{grades[i],7:N2}"); //N2 tells the console to only show to the second decimal
            }                                            // the 7 tells it to leave open seven spaces
            Console.ResetColor();
        }

    }

}

