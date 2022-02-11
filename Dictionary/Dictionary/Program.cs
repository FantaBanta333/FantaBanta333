//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Dictionaries
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            /* Create a dictionary with keys of a string and values of a double
//             *  and call the variable 'pg2'. Using the Random class, add 10 students with
//             *  random grades (1-100) to the pg2 dictionary. */
//            Random random = new Random(); //generate a random class 
//            Dictionary<string, double> pg2 = new Dictionary<string, double>()
//            {
//                {"Deadpool", random.NextDouble() * 100.0}, //copy and paste with different names
//                {"Tanjiro", random.NextDouble() * 100.0},
//                {"Naruto", random.NextDouble() * 100.0 }
//            }; //always add the ';' at the end

//            //OR

//            pg2.Add("Cap", random.NextDouble() * 100.0); //using 'NextDouble' gives you a value between 0-1, and you can use that to multiply 100.0 to stay within the range
//            pg2.Add("Spidey", random.NextDouble() * 100.0);
//            pg2.Add("Iron", random.NextDouble() * 100.0);//copy and paste the 'add' function and change the names
//            pg2.Add("Yuji", random.NextDouble() * 100.0);

//            //OR

//            pg2["Trinity"] = random.NextDouble() * 100.0;
//            pg2["Itachi"] = random.NextDouble() * 100.0; //copy and paste with different names
//            pg2["Hisoka"] = random.NextDouble() * 100.0;


//            PrintGrades(pg2);
//            DropStudent(pg2);
//            CurveStudent(pg2);
//            PrintGrades(pg2);
//        }
//        private static void CurveStudent(Dictionary<string, double> grades)
//        {
//            Console.WriteLine("---------Curve Student---------");
//            Console.WriteLine("Please enter a student to curve: ");
//            string student = Console.ReadLine();
//            if (grades.TryGetValue(student, out double grade))
//            {
//                grades[student] += 5.0F;
//                if (grades[student] > 100) grades[student] = 100;
                
//            }
//            else
//            {
//                Console.WriteLine($"ERROR! {student} was not found.");
//            }

//        }

//        private static void PrintGrades(Dictionary<string, double> grades) //remember to print a name
//        {
//            Console.WriteLine("--------Grades-------");
//            foreach (var grade in grades)
//            {
//                Console.ForegroundColor = ConsoleColor.White; //adding color to the key
//                Console.Write(grade.Key); // 'Write' keeps the dictionary neat
//                                          //to seperate color, seperate the Key/Value
//                Console.CursorLeft = 15; //moves value to the right by 15 spaces

//                //Use a ternary operator as a shorthand for 'If/Else'. 'If' refers to the '?' operators and 'Else' refers to the ':' operators
//                Console.ForegroundColor = (grade.Value < 59.5) ? ConsoleColor.Red :
//                                          (grade.Value < 69.5) ? ConsoleColor.Yellow :
//                                          (grade.Value < 79.5) ? ConsoleColor.Green :
//                                          (grade.Value < 89.5) ? ConsoleColor.Magenta : ConsoleColor.DarkMagenta;
//                Console.WriteLine($"{grade.Value:N2}"); //cut off decimals

//            }
//            Console.ResetColor(); //changes color back
//        }

//        private static void DropStudent(Dictionary<string, double> grades)
//        {
//            Console.WriteLine("----------Dropped Students----------\n");
//            Console.WriteLine("Please enter a name to drop: ");
//            string student = Console.ReadLine();
//            bool wasDropped = grades.Remove(student);
//            if (wasDropped)
//                Console.WriteLine($"{student} was drop from the course.");
//            else
//                Console.WriteLine($"{student} was not on the roster.");
//        }

//    }
//}
