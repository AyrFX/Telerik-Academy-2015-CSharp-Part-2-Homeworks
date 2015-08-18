/*
 * Problem 7. Replace sub-string
 * Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
 * Ensure it will work with large files (e.g. 100 MB).
 */

using System;
using System.IO;

class SubstringReplace
{
    static void Main()
    {
        testFileGenerator();
    }

    static void testFileGenerator()
    {
        StreamWriter writer = new StreamWriter(@"..\..\input.txt");
        using (writer)
        {
            for (int i = 0; i < 25000000; i++)
			{
			    writer.Write("start");
			}
        }
    }
}