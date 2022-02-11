using System;
using System.Collections.Generic;

namespace Day02
{
    class Program
    {
        static void Main(string[] args)
        {
            SplitChallenge();
            ListChallenge();
            ArrayChallenge();

        }

        private static void SplitChallenge()
        {
            Console.WriteLine("----------SPLIT CHALLENGE--------");
            string csv = "1,,,,5,6,,8,9,0,|A|B||D||||JKL";
            char[] delimiters = new char[] { ',', '|' };
            string[] data = csv.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine($"{i+1}. {data[i]}");
            }
        }

        static void ListChallenge()
        {
            List<double> grades = new List<double>();//presizes the internal array
            //Count: # of items added
            //Capacity: size of the internal array (array.Length)

            Random randy = new Random();
            for (int i = 0; i < 10; i++)
            {
                grades.Add(Math.Round(randy.NextDouble() * 100.0, 2));
                Console.WriteLine($"Count: {grades.Count}\tCapacity: {grades.Capacity}");
            }
            PrintGrades(grades);//pass by value or reference? value. what is it copying?

            int failCount = DropFailing(grades);
            Console.WriteLine($"Number of failing grades: {failCount}.");
            PrintGrades(grades);

            Console.WriteLine("---------CURVED GRADES----------");
            List<double> curvedGrades = CurveGrades(grades);
            PrintGrades(curvedGrades);
        }

        static int DropFailing(List<double> course)
        {
            int numberFailing = 0;
            //for (int i = 0; i < course.Count; i++)
            //{
            //    if(course[i] < 59.5)
            //    {
            //        course.RemoveAt(i);
            //        numberFailing++;
            //        i--;//force the loop to evaluate the same index again
            //    }
            //}
            //another way -- use a reverse for loop
            for (int i = course.Count - 1; i >= 0; i--)
            {
                if (course[i] < 59.5)
                {
                    course.RemoveAt(i);
                    numberFailing++;
                }
            }
            return numberFailing;
        }
        static void PrintGrades(List<double> pg2)
        {
            Console.WriteLine("---------GRADES-----------");
            for (int i = 0; i < pg2.Count; i++)
            {
                Console.WriteLine(pg2[i]);
            }
        }
        static List<double> CurveGrades(List<double> pg2)
        {
            List<double> curved = new List<double>(pg2);
            for (int i = 0; i < curved.Count; i++)
            {
                if (curved[i] < 95)
                    curved[i] += 5;
            }
            return curved;
        }

        static void ArrayChallenge()
        {
            Console.WriteLine("---------ARRAY CHALLENGE---------");
            int[] numbers = new int[10];

            Random rando = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rando.Next();
            }
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.Write("How many numbers do you want? ");
            string nums = Console.ReadLine();
            //resize the array
            //1. create a temporary array
            int[] temp = new int[15];
            //2. copy all the other items from numbers to temp
            for (int i = 0; i < numbers.Length; i++)
                temp[i] = numbers[i];
            //3. make the numbers variable point to the new array
            numbers = temp;
        }
    }
}
