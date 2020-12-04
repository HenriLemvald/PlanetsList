using System;
using System.Collections.Generic;
using System.IO;

namespace Planets1
{
    class Program
    {
        private static object path;

        public class planets
        {
            string name;
            int mass;

            public planets(string _name, int _mass)
            {
                name = _name;
                mass = _mass;

            }
            public string Name { get { return name; } }
            public int Mass { get{ return mass; } }
        }
        static void Main(string[] args)
        {
            WritePlanets();
        }
        public static void WritePlanets()
        {
            List<string> planetsList = new List<string>();
            for(int i= 0;i <9; i++)
            {
                Console.WriteLine("Enter the planet:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the mass of the planet:");
                string mass = Console.ReadLine();

                string line = $"{name}/{mass}";
                planetsList.Add(line);
            }

            string filepath = @"C:\Users\opilane\samples";
            string filename = @"PlanetsList.txt";
            File.WriteAllLines(Path.Combine(filepath, filename), planetsList);
        }
    }
}
