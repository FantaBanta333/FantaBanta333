//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Notes
//{
//    class Notes
//    {
//          static void Main(string[] args)

//        {
//            string[] names = new string[] { "Bats", "Batman", "The Dark Knight", "Bruce Wayne" };

//            //3 ways to convert the array to a list:


//            //1. use ToList on the array
//            List<string> theBest = names.ToList();
//            //Start with 'List' constructor, create a random name, '=' add equal sign, insert array name, add 'ToList'


//            //2. pass the array to the List constructor
//            List<string> batMen = new List<string>(names);
//            //Start with 'List' constructor, create a random name, '=' add equal sign, insert 'new', add constructor again, insert array name in '()'


//            //3. Loop over the array and copy each item to the list
//            List<string> bats = new List<string>();
//            for (int i = 0; i < names.Length; i++)
//            {
//                bats.Add(names[i]);
//            }
//            //Start with 'List' constructor, create a random name, add '=' sign, insert 'new', add constructor again, insert '()'
//            //create for loop with array name, random name + 'Add' + (array name) + 'i'




//            //Cloning a List

//            // NOT cloning a List
//            List<string> otherBats = bats;
//            otherBats.Remove("Bruce Wayne");

//            //1. use ToList on the List
//            List<string> best2 = theBest.ToList(); // cloning from example 1 'theBest'

//            //2. pass the original list to the constructor
//            List<string> batMens = new List<string>(batMen); // cloning from example 2 'batMen'


//            //arrays are zero - based indexes
//            string[] Names = new string[3] { "Bats", "Batman", "The Dark Knight" };
//            for (int i = 0; i < names.Length; i++)
//            {
//                Console.WriteLine(names[i]);
//            }
//            names[1] = names[1].ToUpper();


//            //Lists are also zero based indexes
//            List<string> best = new List<string>() { "Bats" }; //#zero index
//            best.Add("Batman"); //#one index
//            best.Add("The Dark Knight"); //#two index


//            //Multiple Delimiters Challenge
//            string villianNames = "Joker,,,Riddler,Catwoman,,TwoFace,Bane|Gordon||Barbara";
//            Console.WriteLine("--------------Characters------------");
//            char[] delimiters = new char[] { ',', '|' };
//            string[] characters = villianNames.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
//            for (int i = 0; i < characters.Length; i++)
//            {
//                Console.WriteLine(characters[i]);
//            }


//            //Count & Capacity
//            List<int> numbers = new List<int>();
//            Info(numbers);
//            numbers.Add(1); //forces a resize of the internal array
//            Info(numbers);
//            numbers.Add(2);
//            Info(numbers);
//            numbers.Add(3);
//            numbers.Add(4); //can not add multiple parameters
//            Info(numbers);
//            numbers.Add(5); //forces another resize
//            Info(numbers); //only accepts entered numbers in increments of one i.e. 5, 6, 7, but not 5, 50, 500


//            //Looping for Lists
//            Console.WriteLine("---------For--------");
//            for (int i = 0; i < numbers.Count; i++) //change 'Length' to 'Count'
//            {
//                Console.WriteLine(numbers[i]);
//            }
//            Console.WriteLine("----------ForEach--------");
//            foreach (var number in numbers) //var takes the place of any variable type (a shorthand)
//            {
//                Console.WriteLine(number);
//            }


//            //List Removing Example
//            List<int> Numbers = new List<int> { 1, 2, 3, 1, 5, 6, 7 };
//            //There are two ways to remove items: Remove(item) or RemoveAt(index)
//            Console.WriteLine(Numbers);
//            numbers.Remove(1); //this will only remove the first one it finds
//            Console.WriteLine(numbers);

//            numbers.RemoveAt(2);
//            Console.WriteLine(numbers);
//        }

//        private static void Info(List<int> nums)
//        {
//            Console.WriteLine($"Count: {nums.Count}\tCapacity: {nums.Capacity}");
//        }

//        private static void ArrayChallenge()
//        {
//            Random random = new Random();
//            int[] numbers = new int[10];
//            for (int i = 0; i < numbers.Length; i++)
//            {
//                numbers[i] = random.Next();
//            }
//            for (int i = 0; i < numbers.Length; i++)
//            {
//                Console.WriteLine(numbers[i]);
//            }
//        }
//    }
//}

