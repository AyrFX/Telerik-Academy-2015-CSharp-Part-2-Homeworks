/*
 * Problem 3. Line numbers
 * Write a program that reads a text file and inserts line numbers in front of each of its lines.
 * The result should be written to another text file.
 */

using System;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\input.txt");
        StreamWriter writer = new StreamWriter(@"..\..\output.txt");
        string line = "";
        int counter = 0;
        using (writer)
        {
            using (reader)
            {
                line = line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine("{0:D2} {1}", counter, line);
                    line = reader.ReadLine();
                    counter++;
                }
            }
        }
    }
}