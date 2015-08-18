/*
 * Problem 4. Compare text files
 * Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines
 * that are different.
 * Assume the files have equal number of lines.
 */

using System;
using System.IO;

class TextFilesCompare
{
    static void Main()
    {
        StreamReader firstReader = new StreamReader(@"..\..\input1.txt");
        StreamReader secondReader = new StreamReader(@"..\..\input2.txt");
        string fReaderLine = firstReader.ReadLine();
        string sReaderLine = secondReader.ReadLine();
        int sameCounter = 0, differentCounter = 0;
        while (fReaderLine != null)
        {
            if (fReaderLine == sReaderLine)
            {
                sameCounter++;
            }
            else
            {
                differentCounter++;
            }
            fReaderLine = firstReader.ReadLine();
            sReaderLine = secondReader.ReadLine();
        }
        Console.WriteLine("The same lines are {0} and the different lines are {1}.", sameCounter, differentCounter);
    }
}