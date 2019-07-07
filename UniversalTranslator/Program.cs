using System;
using UniversalTranslator;

namespace UniversalTranslator_Onunez
{
    class Program
    {
        static string path;
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the path to the temperatures file:");
            path = Console.ReadLine();
            FileTemperature f = new FileTemperature();
            var temps = f.ReadTemperatureFile(path);
            f.ConvertValues(ref temps);
        }
    }
}
