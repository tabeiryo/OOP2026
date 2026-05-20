using System;
using System.ComponentModel;

namespace section01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cities = new List<string> {
                "Tokyo",
                "New Delhi",
                "Bangkok",
                "London",
                "Paris",
                "Berlin",
                "Canberra",
                "Hong Kong",
            };

            var exists = cities.Exists(s => s[0] == 'A');
            Console.WriteLine(exists);

            var name = cities.Find(s => s.Length == 6);
            Console.WriteLine(name);

            int index = cities.FindIndex(s => s =="Berlin");
            Console.WriteLine(index);

            
        }

    }
}
