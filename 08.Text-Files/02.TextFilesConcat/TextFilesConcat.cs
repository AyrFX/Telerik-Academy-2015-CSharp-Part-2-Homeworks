/*
 * Problem 2. Concatenate text files
 * Write a program that concatenates two text files into another text file.
 */

using System;
using System.IO;

class TextFilesConcat
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\input1.txt");
        StreamWriter writer = new StreamWriter(@"..\..\output.txt");
        string line = "";
        using (writer)
        {
            using (reader)
            {
                line = line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
            reader = new StreamReader(@"..\..\input2.txt");
            line = "";
            using (reader)
            {
                line = line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
        }
    }
}