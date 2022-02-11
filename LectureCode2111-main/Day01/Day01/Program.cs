using System;
using System.Numerics;

namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMessage();
            string msg = GetMessage();
            PrintMessage(msg);
            TimeStamp(ref msg);
            PrintMessage(msg);

            int number = 5;
            int multiplier = 3;
            Factor(number, multiplier);//Pass by Value: COPY
            number = 10;
            Factor(number, multiplier);

            Console.WriteLine("Pass BY Reference");
            Console.Write($"{number} * {multiplier} = ");
            Factored(ref number, multiplier);//number is Pass by Reference (ALIAS)                                             
            Console.WriteLine(number);


            Console.WriteLine("Pass BY Reference using OUT");
            int pg2Grade = 85;
            int curve = 5;
            int curved;
            CurveGrade(pg2Grade, curve, out curved);
            Console.WriteLine($"{pg2Grade} was curved {curve} points to {curved}.");

            MyFavoriteNumber(out int myFave);
            Console.WriteLine($"My favorite number is {myFave}");

        }

        static void MyFavoriteNumber(out int favorite)
        {
            Console.Write("What is your favorite number? ");
            int number;

            do
            {
                try
                {
                    string input = Console.ReadLine();
                    number = int.Parse(input);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("uh, that's not a number! Please try again...");
                }
            } while (true);
            favorite = number;
        }

        static void CurveGrade(int grade, int curve, out int curvedGrade)
        {
            grade += curve;
            if (grade > 100) grade = 100;
            curvedGrade = grade;
        }

        static void TimeStamp(ref string msg)
        {
            msg = $"{DateTime.Now} {msg}";
        }

        static void Factored(ref int num, int factor)
        {
            num *= factor;//will change number in Main
        }

        static void Factor(int num, int factor = 5)
        {
            //$ - C# interpolated string
            Console.WriteLine($"{num} * {factor} = {num * factor}");
        }

        //public static void PrintMessage()
        //{
        //    Console.WriteLine("Hello Gotham.");
        //}

        public static void PrintMessage(string message = "Hello Gotham.")
        {
            Console.WriteLine(message);
        }

        public static string GetMessage()
        {
            Console.Write("Please enter a message: ");
            string message = string.Empty;
            message = Console.ReadLine();
            return message;
        }
    }

}
