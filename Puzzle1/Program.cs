using System;
using System.IO;
using System.Linq;

namespace Puzzle1
{

    // https://adventofcode.com/2018/day/1

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(File.ReadLines("input/input.txt")
                .Select(p => Int32.TryParse(p, out int offs) ? offs : 0)
                .Aggregate((p, q) => p + q));
        }

    }

}
