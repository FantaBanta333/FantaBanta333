using System;
using System.Collections.Generic;
using System.Linq;

namespace Day05
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Batman", s2 = "Aquaman";
            int compResult = s1.CompareTo(s2);
            if (compResult == 0)    Console.WriteLine($"{s1} EQUALS {s2}");
            else if(compResult > 0) Console.WriteLine($"{s1} GREATER THAN {s2}"); 
            else if(compResult < 0) Console.WriteLine($"{s1} LESS THAN {s2}");

            CompareStrings();


            for (int i = 5; i < 200; i+=5)
            {

            }
            DoIt(5);

            Console.WriteLine("---------BATS--------");
            Bats(0);

            Console.WriteLine("\n---------SWAP-------------");
            int[] numbers = new int[] { 5, 7, 13, 1, 10, 42, 50 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Swap(numbers, 2, 3);
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            Split(numbers.ToList());

            Console.WriteLine("----------FACTORIAL----------");
            long result = Factorial(5);
            Console.WriteLine($"5! = {result}");

            Console.WriteLine("The end.");
        }

        static long Factorial(int N)
        {
            if (N <= 1) return 1;

            long result = N * Factorial(N - 1);
            return result;
        }

        static void Split(List<int> data)
        {
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            for (int i = 0; i < data.Count; i++)
            {
                if (i < data.Count / 2)
                    left.Add(data[i]);
                else
                    right.Add(data[i]);
            }
            Console.WriteLine("\n-----LEFT------");
            foreach (var item in left)
                Console.WriteLine(item);
            Console.WriteLine("-----RIGHT------");
            foreach (var item in right)
                Console.WriteLine(item);
        }

        static void CompareStrings()
        {
            Console.Write("Enter a name to compare: ");
            string s1 = Console.ReadLine();
            Console.Write("Enter another name to compare: ");
            string s2 = Console.ReadLine();

            int compResult = string.Compare(s1, s2, true);//to ignore case
            //bool areEqual = s1.Equals(s2, StringComparison.CurrentCultureIgnoreCase);

            if (compResult == 0) Console.WriteLine($"{s1} EQUALS {s2}");
            else if (compResult > 0) Console.WriteLine($"{s1} GREATER THAN {s2}");
            else if (compResult < 0) Console.WriteLine($"{s1} LESS THAN {s2}");
        }

        static void Swap(int[] nums, int index1, int index2)
        {
            int temp = nums[index1];
            nums[index1] = nums[index2];
            nums[index2] = temp;
        }

        static void Bats(int i)
        {
            if(i < 100)
            {
                Console.Write((char)78);
                Console.Write((char)65);
                Console.Write(' ');
                Bats(i + 1);
            }
        }

        static void DoIt(int num)
        {
            if (num < 200)
            {
                Console.WriteLine(num);
                DoIt(num+5);
            }
            Console.WriteLine(num);
        }//returns
    }
}
