using System;
using System.IO;

class Program
{
    static void Main()
    {
        P1();
        P2();
    }

    static void P1()
    {
        string[] lines = File.ReadAllLines("day1.txt");
        int dial = 50;
        int counter = 0;
        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i];
            int number = int.Parse(line.Substring(1));
            if (line[0] == 'L')
                dial -= number;
            else
                dial += number;

            dial = (dial % 100 + 100) % 100;
            if (dial == 0) counter++;
        }
        Console.WriteLine("Part 1: " + counter);
    }

    static void P2()
    {
        string[] lines = File.ReadAllLines("day1.txt");
        int dial = 50;
        int counter = 0;

        foreach (string line in lines)
        {
            int distance = int.Parse(line.Substring(1));

            for (int i = 0; i < distance; i++)
            {
                if (line[0] == 'L')
                {
                    dial--;
                    if (dial == -1) dial = 99;
                }
                else
                {
                    dial++;
                    if (dial == 100) dial = 0;
                }

                if (dial == 0)
                    counter++;
            }
        }
        Console.WriteLine("Part 2: " + counter);
    }
}