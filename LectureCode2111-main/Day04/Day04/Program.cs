using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day04
{
    enum Superpowers
    {
        Flight, HeatVision, Money, Speed, Invisibility, Strength, Swim
    }
    class Superhero
    {
        public string Name { get; set; }
        public string SecretIdentity { get; set; }
        public Superpowers Powers { get; set; }
        public override string ToString()
        {
            return $"Hi. My name is {Name} ({SecretIdentity}). I can {Powers}!";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"sample.txt";
            char delimiter = ';';
            //1. OPEN THE FILE
            using (StreamWriter sw = new StreamWriter(filePath))//IDisposable
            {
                //2. Write to the file
                sw.Write("Because I'm Batman!");
                sw.Write(delimiter);
                sw.Write(5);
                sw.Write(delimiter);
                sw.Write(12.6);
                sw.Write(delimiter);
                sw.Write(true);
                //sw.Close(); don't need to do b/c the } closes it
            }//3. CLOSES THE FILE. Calls Dispose() on the resource

            WriteData(filePath);
            ReadData(filePath);

            #region Serializing
            List<Superhero> faves = new List<Superhero>();
            faves.Add(new Superhero() { Name = "Batman", SecretIdentity = "Bruce", Powers = Superpowers.Money });
            faves.Add(new Superhero() { Name = "Wonder Woman", SecretIdentity = "Diana", Powers = Superpowers.Strength });
            faves.Add(new Superhero() { Name = "Aquaman", SecretIdentity = "Fishboy", Powers = Superpowers.Swim });
            faves.Add(new Superhero() { Name = "Superman", SecretIdentity = "Clark", Powers = Superpowers.Flight });
            faves.Add(new Superhero() { Name = "Flash", SecretIdentity = "Barry", Powers = Superpowers.Speed });

            //change the extension to .json
            filePath = Path.ChangeExtension(filePath, ".json"); //sample.json
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                using (JsonTextWriter jtw = new JsonTextWriter(sw))
                {
                    jtw.Formatting = Formatting.Indented;
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(jtw, faves);
                }
            }
            //OR...with 1 line of code
            File.WriteAllText(filePath, JsonConvert.SerializeObject(faves, Formatting.Indented));

            filePath = "list.json";
            WriteJson(filePath);
            #endregion

            #region Deserializing
            filePath = "sample.json";
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                Console.WriteLine(jsonData);
                //T = List<Superhero>
                try
                {
                    List<Superhero> justiceLeague = JsonConvert.DeserializeObject<List<Superhero>>(jsonData);
                    foreach (Superhero super in justiceLeague)
                    {
                        Console.WriteLine(super);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("File does not exists.");
            }

            filePath = "list.json";
            try
            {
                List<int> myList = ReadJson(filePath);
                foreach (var item in myList)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR! ERROR!");
            }
            #endregion
        }

        static List<int> ReadJson(string filePath)
        {
            if (File.Exists(filePath))
            {
                string jsonText = File.ReadAllText(filePath);
                try
                {
                    List<int> data = JsonConvert.DeserializeObject<List<int>>(jsonText);
                    return data;
                }
                catch (Exception)
                {
                    Console.WriteLine("The data was not in the correct format.");
                    throw;
                }
            }
            else
            {
                throw new InvalidOperationException($"{filePath} does not exists.");
            }
        }

        static void WriteJson(string filePath)
        {
            List<int> data = new List<int>() { 1, 2, 4, 5, 6, 7, 8, 9, 0 };
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                using (JsonTextWriter jtw = new JsonTextWriter(sw))
                {
                    jtw.Formatting = Formatting.Indented;
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(jtw, data);
                }
            }
        }

        static void ReadData(string filePath)
        {
            List<string> dataList = new List<string>();
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('?');
                    dataList = data.ToList();
                }
            }
            //OR
            dataList = File.ReadAllText(filePath).Split('?').ToList();

            foreach (var item in dataList)
            {
                Console.WriteLine(item);
            }
        }

        static void WriteData(string fPath)
        {
            List<int> data = new List<int>() { 1, 2, 4, 5, 6, 7, 8, 9, 0 };
            char delim = '?';
            using (StreamWriter sw = new StreamWriter(fPath))
            {
                for (int i = 0; i < data.Count; i++)
                {
                    if (i != 0) sw.Write(delim);
                    sw.Write(data[i]);
                }
            }
        }
    }
}
