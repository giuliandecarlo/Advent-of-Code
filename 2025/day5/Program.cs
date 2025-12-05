using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        P1();
        P2();
    }

    static void P1()
    {
        var lines = File.ReadAllLines("day5.txt");

        List<(long start, long end)> ranges = new();
        List<long> numbers = new();
        int count = 0;

        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
                continue;

            if (line.Contains('-'))
            {
                var parts = line.Split('-');
                ranges.Add((long.Parse(parts[0]), long.Parse(parts[1])));
            }
            else if (long.TryParse(line, out long n))
            {
                numbers.Add(n);
            }
        }

        foreach (long n in numbers)
        {
            foreach (var (start, end) in ranges)
            {
                if (n >= start && n <= end)
                {
                    count++;
                    break;
                }
            }
        }

        Console.WriteLine("Part 1: " + count);
    }

    static void P2()
    {
        Console.WriteLine("Part 2: ");
    }
}
