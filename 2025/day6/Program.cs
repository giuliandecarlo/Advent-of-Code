using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        P1();
        P2();
    }

    static void P1()
    {
        string[] lines = File.ReadAllLines("day6.txt");
        string[] symbols = lines[^1].Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int cols = symbols.Length;
        long[] results = Enumerable.Repeat(0L, cols).ToArray();
        long[] products = Enumerable.Repeat(1L, cols).ToArray();

        for (int i = 0; i < lines.Length - 1; i++)
        {
            int[] numbers = lines[i]
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int y = 0; y < cols; y++)
            {
                if (symbols[y] == "+")
                {
                    results[y] += numbers[y];
                }
                else if (symbols[y] == "*")
                {
                    products[y] *= numbers[y];
                }
            }
        }

        long total = 0;
        for (int y = 0; y < cols; y++)
        {
            if (symbols[y] == "+")
                total += results[y];
            else if (symbols[y] == "*")
                total += products[y];
        }

        Console.WriteLine("Part 2: "+total);
    }


    static void P2()
    {
        var lines = File.ReadAllLines("day6.txt");

        Console.WriteLine("Part 2: ");
    }
}