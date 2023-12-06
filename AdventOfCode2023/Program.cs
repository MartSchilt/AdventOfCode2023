using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Advent of Code 2023!");

            Day1 day1 = new();
            var outputDay1 = day1.Run();
            Console.WriteLine(outputDay1);

            Console.WriteLine("Press 'Enter' to quit");
            Console.ReadLine(); // Wait for player input to stop the program
        }
    }
}