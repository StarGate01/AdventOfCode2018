using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Puzzle2
{

    // https://adventofcode.com/2018/day/1

    class Program
    {

        static void Main(string[] args)
        {
            var seen = new List<int>();
            var result = 0;
            var list = File.ReadLines("input/input.txt")
                .Select(p => Int32.TryParse(p, out int offs) ? offs : 0)
                .ToList();

            while (true)
            {
                foreach (var p in list)
                {
                    result += p;
                    if (seen.Contains(result))
                    {
                        Console.WriteLine(result);
                        Environment.Exit(0);
                    }
                    seen.Add(result);
                }
            }
        }

    }

}
