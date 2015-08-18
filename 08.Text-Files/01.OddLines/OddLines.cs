/*
 * Problem 1. Odd lines
 * Write a program that reads a text file and prints on the console its odd lines.
 */

using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\test.txt");
        string line = "";
        int counter = 0;
        using (reader)
        {
            while (line != null)
            {
                line = reader.ReadLine();
                if (counter % 2 == 1)
                {
                    Console.WriteLine(line);
                }
                counter++;
            }
        }
    }
}