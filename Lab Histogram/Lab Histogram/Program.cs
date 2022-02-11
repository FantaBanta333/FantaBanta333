using System;
using System.IO;
using System.Collections.Generic;

class Histogram
{

    public static int ReadInteger(string prompt, int min, int max)
    {
        int num;
        string input;
        Console.Write(prompt);
        input = Console.ReadLine();
        try
        {
            num = Convert.ToInt32(input);
            if (num >= min && num <= max)
                return num;
            else
            {
                Console.WriteLine("Input not in range (" + min + "," + max + "). Try again!");
                return ReadInteger(prompt, min, max);
            }

        }
        catch (Exception)
        {
            Console.WriteLine("Invalid input! Integers only, please, try again!");
            return ReadInteger(prompt, min, max);
        }

    }

    private static void ReadString(string prompt, ref string value)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            value = Console.ReadLine();
            if (String.IsNullOrEmpty(value))
            {
                Console.WriteLine("Please enter the string");
            }
            else
            {
                break;
            }
        }
        Console.WriteLine("The stored string in ref " + value);
    }

    private static void ReadChoice(string prompt, string[] options, out int selection)
    {
        Console.WriteLine("\nMENU");
        for (int i = 0; i < options.Length; i++)
        {
            Console.WriteLine(options[i]);
        }
        Console.WriteLine();
        selection = ReadInteger(prompt, 1, options.Length);
    }

    private static string GetSpeech()
    {
        string text = "My third story is about death. When I was 17, I read a quote that went something like: If you live each day as if it was your last, someday you’ll most certainly be right. " +
            "It made an impression on me, and since then, for the past 33 years, I have looked in the mirror every morning and asked myself: If today were the last day of my life, " +
            "would I want to do what I am about to do today? And whenever the answer has been No for too many days in a row, I know I need to change something. Remembering that I’ll be dead " +
            "soon is the most important tool I’ve ever encountered to help me make the big choices in life. Because almost everything — all external expectations, all pride, all fear of " +
            "embarrassment or failure — these things just fall away in the face of death, leaving only what is truly important. Remembering that you are going to die is the best way I know" +
            " to avoid the trap of thinking you have something to lose. You are already naked. There is no reason not to follow your heart. About a year ago I was diagnosed with cancer. " +
            "I had a scan at 7:30 in the morning, and it clearly showed a tumor on my pancreas. I didn’t even know what a pancreas was. The doctors told me this was almost certainly a type of" +
            " cancer that is incurable, and that I should expect to live no longer than three to six months. My doctor advised me to go home and get my affairs in order, which is doctor’s" +
            " code for prepare to die. It means to try to tell your kids everything you thought you’d have the next 10 years to tell them in just a few months. It means to make sure" +
            " everything is buttoned up so that it will be as easy as possible for your family. It means to say your goodbyes. I lived with that diagnosis all day. Later that evening I had" +
            " a biopsy, where they stuck an endoscope down my throat, through my stomach and into my intestines, put a needle into my pancreas and got a few cells from the tumor. I was" +
            " sedated, but my wife, who was there, told me that when they viewed the cells under a microscope the doctors started crying because it turned out to be a very rare form of " +
            "pancreatic cancer that is curable with surgery. I had the surgery and I’m fine now. This was the closest I’ve been to facing death, and I hope it’s the closest I get for a few" +
            " more decades. Having lived through it, I can now say this to you with a bit more certainty than when death was a useful but purely intellectual concept: No one wants to die." +
            " Even people who want to go to heaven don’t want to die to get there. And yet death is the destination we all share. No one has ever escaped it. And that is as it should be, " +
            "because Death is very likely the single best invention of Life. It is Life’s change agent. It clears out the old to make way for the new. Right now the new is you, but someday" +
            " not too long from now, you will gradually become the old and be cleared away. Sorry to be so dramatic, but it is quite true. Your time is limited, so don’t waste it living" +
            " someone else’s life. Don’t be trapped by dogma — which is living with the results of other people’s thinking. Don’t let the noise of others’ opinions drown out your own inner" +
            " voice. And most important, have the courage to follow your heart and intuition. They somehow already know what you truly want to become. Everything else is secondary. When I" +
            " was young, there was an amazing publication called The Whole Earth Catalog, which was one of the bibles of my generation. It was created by a fellow named Stewart Brand not" +
            " far from here in Menlo Park, and he brought it to life with his poetic touch. This was in the late 1960s, before personal computers and desktop publishing, so it was all made" +
            " with typewriters, scissors and Polaroid cameras. It was sort of like Google in paperback form, 35 years before Google came along: It was idealistic, and overflowing with neat" +
            " tools and great notions. Stewart and his team put out several issues of The Whole Earth Catalog, and then when it had run its course, they put out a final issue. It was the " +
            "mid-1970s, and I was your age. On the back cover of their final issue was a photograph of an early morning country road, the kind you might find yourself hitchhiking on if" +
            " you were so adventurous. Beneath it were the words: Stay Hungry. Stay Foolish. It was their farewell message as they signed off. Stay Hungry. Stay Foolish. And I have always" +
            " wished that for myself. And now, as you graduate to begin anew, I wish that for you. Stay Hungry. Stay Foolish.";
        return text;
    }

    public static void Main(string[] args)
    {

        int menuChoice = 0;
        string[] mainMenu = new string[]
        {
            "1. The Speech",
            "2. List of Words",
            "3. Show Histogram",
            "4. Search for Word",
            "5. Remove Word",
            "6. Exit\n"
        };

        // Read the text from the file
        string text = GetSpeech();

        // List of all the words
        string[] words = text.Split(new char[] { '.', ',', ' ' });

        // List of Unique Words
        List<string> list = new List<string>();
        for (int i = 0; i < words.Length; i++)
        {
            bool repeated = false;

            for (int j = 0; j < i; j++)
            {
                if (words[j].ToLower() == words[i].ToLower())  //I actually didn't know what this did, the internet told me to do this
                {
                    repeated = true;
                    break;
                }
            }

            if (!repeated)
                list.Add(words[i]);
        }

        // Adding the words and count to the dictionary
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        foreach (string member in list)  //so that I could add to this 'list' variable
        {
            int count = 0;
            foreach (string word in words)
            {
                if (word.ToLower() == member.ToLower())
                    count++;
            }
            dictionary.Add(member, count);
        }
        bool continueLoop = true;
        while (menuChoice != mainMenu.Length)
        {
            ReadChoice("Choice? ", mainMenu, out menuChoice);

            switch (menuChoice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine(text);
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    string word = text;
                    string[] wordStrings = text.Split(new char[] { '.', ',', ' ' });
                    for (int i = 0; i < wordStrings.Length; i++)
                    {
                        Console.WriteLine(wordStrings[i]);
                    }
                    break;
                case 3:
                    Console.WriteLine("\nHistogram:-");
                    Console.Clear();
                    Random random = new Random();
                    Console.BackgroundColor = (ConsoleColor)random.Next(16);        
                    int size = random.Next(1, Console.WindowWidth);
                    Console.Write(new string(' ', size));
                    Console.ResetColor();
                    foreach (KeyValuePair<string, int> kvp in dictionary)
                    {
                        Console.WriteLine("Word = {0}, Count = {1}", kvp.Key, kvp.Value);
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.Write(new string(' ', kvp.Value));
                        Console.ResetColor();
                    }
                    break;
                case 4:
                    string wordOne = "";
                    ReadString("\nSearch word to find? ", ref wordOne);
                    if (!dictionary.ContainsKey(wordOne))
                    {
                        Console.WriteLine("Word not Found!");
                    }
                    else
                    {
                        Console.WriteLine("\n\t{0} {1}", wordOne, dictionary[wordOne]);
                    }
                    break;
                case 5:
                    string inputOne = "";
                    ReadString("\nEnter the Word: ", ref inputOne);
                    if (!dictionary.ContainsKey(inputOne))
                    {
                        Console.WriteLine("{0} is not Found.", inputOne);
                    }
                    else
                    {
                        dictionary.Remove(inputOne);
                    }
                    break;
                case 6:
                    Console.WriteLine($"{mainMenu[5]}");
                    continueLoop = false;
                    break;

                default: continue;
            }
        }


    }
}