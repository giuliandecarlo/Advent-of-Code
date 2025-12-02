using System;
using System.IO;
using System.Text.RegularExpressions;
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
    long sum = 0;
    string content = File.ReadAllText("day2.txt");

    Regex regex = new Regex(@"(\d+)-(\d+)");
    List<(long Start, long End)> ranges = new List<(long, long)>();
    foreach (Match match in regex.Matches(content))
    {
        long start = long.Parse(match.Groups[1].Value);
        long end = long.Parse(match.Groups[2].Value);
        ranges.Add((start, end));
    }

    foreach (var r in ranges)
    {
        for (long i = r.Start; i <= r.End; i++)
        {
            string nstring = i.ToString();
            if (nstring.Length % 2 != 0)
            {
                continue;
            }
            int half = nstring.Length / 2;
            string firstHalf  = nstring.Substring(0, half);
            string secondHalf = nstring.Substring(half, half);

            if (firstHalf == secondHalf)
                sum += i;
        }
    }
    Console.WriteLine("Part 1: " + sum);
}
    static void P2()
    {
        long sum = 0;
        string content = File.ReadAllText("day2.txt");

        Regex regex = new Regex(@"(\d+)-(\d+)");
        var ranges = regex.Matches(content)
                        .Select(m => (Start: long.Parse(m.Groups[1].Value), End: long.Parse(m.Groups[2].Value)))
                        .ToList();

        foreach (var r in ranges)
        {
            for (long i = r.Start; i <= r.End; i++)
            {
                string s = i.ToString();
                int len = s.Length;
                bool invalid = false;

                for (int block = 1; block <= len / 2; block++)
                {
                    if (len % block != 0) continue;
                    string part = s.Substring(0, block);
                    string repeated = string.Concat(Enumerable.Repeat(part, len / block));
                    if (repeated == s)
                    {
                        invalid = true;
                        break;
                    }
                }

                if (invalid)
                    sum += i;
            }
        }
        Console.WriteLine("Part 2: " + sum);
    }
}