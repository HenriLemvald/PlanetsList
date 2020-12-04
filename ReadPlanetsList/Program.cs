using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ReadPlanetsList
{
    class Program
    {
        private static object list;

        public class planets
        {
            string name;
            int mass;

            public planets(string _name, int _mass)
            {
                name = _name;
                mass = _mass;
                Console.WriteLine($"{name} created.");
            }
            public string Name { get { return name; } }
            public int Mass { get{ return mass; } }
        }
        static void Main(string[] args)
        {
            ReadPlanetsList();
        }
        public static void ReadPlanetsList()
        {
            string filepath = @"C:\Users\opilane\samples";
            
            string filename = @"PlanetsList.txt";
            
            List<planets> planets = new List<planets>();

            List<string> LinesFromFile = File.ReadAllLines(Path.Combine(filepath, filename)).ToList();

            for (int i = 0; i < LinesFromFile.Count; i++)
            {
                string line = (string)LinesFromFile[i];
                
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                
                planets newitem = new planets(tempArray[0], Int32.Parse(tempArray[1]));
                
                planets.Add(newitem);
            }
            Console.WriteLine("your planet list:");
            int total = 0;


            foreach (planets item in planets)
            {
                Console.WriteLine($"Item: {item.Name}; price: {item.Mass}");
                
                total += item.Mass;
            }
            Console.WriteLine($"your planet list total: {total}");
        }
    }
}
