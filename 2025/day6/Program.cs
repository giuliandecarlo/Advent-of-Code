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

        Console.WriteLine("Part 1: " + total);
    }
    static void P2()
    {
        string[] lines = File.ReadAllLines("day6.txt");
        int height = lines.Length - 1;
        int width = lines.Max(l => l.Length);

        for (int i = 0; i < lines.Length; i++)
            lines[i] = lines[i].PadRight(width);

        bool IsSeparator(int c)
        {
            for (int r = 0; r < lines.Length; r++)
            {
                char ch = lines[r][c];
                if (char.IsDigit(ch) || ch == '+' || ch == '*')
                    return false;
            }
            return true;
        }

        long total = 0;
        int col = width - 1;

        while (col >= 0)
        {
            if (IsSeparator(col))
            {
                col--;
                continue;
            }

            int end = col;
            int start = col;

            while (start >= 0 && !IsSeparator(start))
                start--;

            start++;

            char op = '?';

            for (int c = start; c <= end; c++)
            {
                char ch = lines[height][c];
                if (ch == '+' || ch == '*')
                {
                    op = ch;
                    break;
                }
            }

            List<long> numbers = new List<long>();

            for (int c = start; c <= end; c++)
            {
                string s = "";
                for (int r = 0; r < height; r++)
                {
                    char ch = lines[r][c];
                    if (char.IsDigit(ch))
                        s += ch;
                }

                if (s.Length > 0)
                    numbers.Add(long.Parse(s));
            }

            long blockResult;
            if (op == '+')
                blockResult = numbers.Sum();
            else if (op == '*')
                blockResult = numbers.Count > 0 ? numbers.Aggregate(1L, (a, b) => a * b) : 0;
            else
                blockResult = 0;

            total += blockResult;
            col = start - 1;
        }
        Console.WriteLine("Part 2: " + total);
    }
}