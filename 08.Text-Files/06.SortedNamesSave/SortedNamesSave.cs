/*
 * Problem 6. Save sorted names
 * Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
 * 
 * Example:
 * input.txt 	output.txt
 * Ivan         George
 * Peter        Ivan
 * Maria        Maria
 * George 	    Peter
 */

using System;
using System.Collections.Generic;
using System.IO;

class SortedNamesSave
{
    static void Main()
    {
        List<string> namesList = new List<string>();
        StreamReader reader = new StreamReader(@"..\..\input.txt");
        string line = "";
        using (reader)
        {
            line = reader.ReadLine();
            while (line != null)
            {
                namesList.Add(line);
                line = reader.ReadLine();
            }
        }
        namesList.Sort();
        StreamWriter writer = new StreamWriter(@"..\..\output.txt");
        using (writer)
        {
            for (int i = 0; i < namesList.Count; i++)
            {
                writer.WriteLine(namesList[i]);
            }
        }
    }
}