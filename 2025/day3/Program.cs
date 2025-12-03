using System;
using System.IO;

class Program
{
    static void Main()
    {
        P_1_2(2);
        P_1_2(12);
    }


static void P_1_2(int targetLength)
    {

        string[] lines = File.ReadAllLines("day3.txt");
        long totalSum = 0;

        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            int dropCount = line.Length - targetLength;

            if (dropCount < 0) continue; 

            List<char> resultStack = new List<char>();

            foreach (char c in line)
            {
                while (resultStack.Count > 0 && dropCount > 0 && resultStack.Last() < c)
                {
                    resultStack.RemoveAt(resultStack.Count - 1);
                    dropCount--;
                }
                resultStack.Add(c);
            }
            string finalNumberStr = new string(resultStack.Take(targetLength).ToArray());
            
            long bankJoltage = long.Parse(finalNumberStr);
            totalSum += bankJoltage;
        }
        Console.WriteLine($"Result: {totalSum}");
    }
}