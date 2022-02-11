using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Day06
{
    class Program
    {
        static Dictionary<int, long> _fibs = new Dictionary<int, long>();
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 5, 1, 20, 60, 129, 7, 13 };
            int index = LinearSearch(nums, 13);
            Console.WriteLine($"13 is found at index {index}."); 

            index = LinearSearch(nums, 42);
            Console.WriteLine($"42 is found at index {index}.");
            Console.ReadKey();
            //add exit conditions to the dictionary
            _fibs.Add(0, 0);
            _fibs[1] = 1;

            Stopwatch sw = new Stopwatch();
            for (int i = 0; i < 145; i++)
            {
                sw.Reset();
                sw.Start();
                long result = Fib(i);
                sw.Stop();
                long ms = sw.ElapsedMilliseconds;
                Console.Write($"Fibonacci({i}) = {result}");
                Console.CursorLeft = 35;
                Console.WriteLine($"{ms,6}");
            }
        }

        //linear performance. O(N)
        static int LinearSearch(List<int> searchList, int searchItem)
        {
            int foundIndex = -1;
            for (int i = 0; i < searchList.Count; i++)
            {
                if (searchItem == searchList[i])
                {
                    foundIndex = i;
                    break;
                }
            }
            return foundIndex;
        }

        //linear performance!
        static long Fib(int N)
        {
            if (_fibs.TryGetValue(N, out long result))
                return result;//exit condition!

            result = Fib(N - 1) + Fib(N - 2);
            _fibs[N] = result;//add a new exit condition
            return result;
        }

        //exponential performance :-(
        static long Fibonacci(int N)
        {
            if (N == 0) return 0;
            if (N == 1) return 1;
            long result = Fibonacci(N - 1) + Fibonacci(N - 2);
            return result;
        }
    }
}
