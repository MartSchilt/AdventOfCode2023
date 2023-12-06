using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCode2023
{
    public class Day1
    {
        public int Run()
        {
            var input = Helper.GetInput("Day1Input.txt");

            var output = 0;
            foreach (var s in input)
            {
                var matches = Regex.Matches(s, @"\d|(one|two|three|four|five|six|seven|eight|nine)");
                var begin = ConvertToInt(matches[0].Value);
                var end = ConvertToInt(matches[matches.Count - 1].Value);
                output += Int32.Parse($"{begin}{end}");
            }

            return output;
        }

        private int ConvertToInt(string s)
        {
            try
            {
                switch (s)
                {
                    case "one":
                        return 1;
                    case "two":
                        return 2;
                    case "three":
                        return 3;
                    case "four":
                        return 4;
                    case "five":
                        return 5;
                    case "six":
                        return 6;
                    case "seven":
                        return 7;
                    case "eight":
                        return 8;
                    case "nine":
                        return 9;
                    default:
                        return Convert.ToInt32(s);
                }
            }
            catch
            {
                Console.WriteLine($"Cannot convert: {s}");
                return 0;
            }
        }
    }
}
