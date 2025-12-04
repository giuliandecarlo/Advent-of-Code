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
    string[] lines = File.ReadAllLines("day4.txt");

    int rows = lines.Length;
    int cols = lines[0].Length;
    int count = 0;

    int[] dx = { -1, -1, -1, 0, 0, 1, 1, 1 };
    int[] dy = { -1, 0, 1, -1, 1, -1, 0, 1 };

    for (int r = 0; r < rows; r++)
    {
        for (int c = 0; c < cols; c++)
            {
            int neighbors = 0;
            if (lines[r][c] != '@')
                continue;

            for (int k = 0; k < 8; k++)
            {
                int nr = r + dx[k];
                int nc = c + dy[k];

                if (nr < 0 || nr >= rows || nc < 0 || nc >= cols)
                    continue;

                if (lines[nr][nc] == '@')
                    neighbors++;
            }

            if (neighbors < 4)
                count++;
        }
    }

    Console.WriteLine("Part 1: " + count);
}

    static void P2()
    {
        string content = File.ReadAllText("day4.txt");
        Console.WriteLine("Part 2: ");
    }
}