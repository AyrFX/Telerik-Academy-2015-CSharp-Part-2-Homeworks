/*
 * Problem 14. Word dictionary
 * 
 * A dictionary is stored as a sequence of text lines containing words and their explanations.
 * Write a program that enters a word and translates it by using the dictionary.
 * 
 * Sample dictionary:
 * input 	output
 * .NET 	platform for applications from Microsoft
 * CLR 	    managed execution environment for .NET
 * namespace 	hierarchical organization of classes
 */

using System;
using System.Collections.Generic;

class WordDictionary
{
    static void Main()
    {
        List<string> dictionary = new List<string>();
        dictionary.Add(".NET<<expl>>platform for applications from Microsoft");
        dictionary.Add("CLR<<expl>>managed execution environment for .NET");
        dictionary.Add("namespace<<expl>>hierarchical organization of classes");
        Console.Write("Please enter word to explain: ");
        string word = Console.ReadLine();
        for (int i = 0; i < dictionary.Count; i++)
        {
            int explTagStart = dictionary[i].IndexOf("<<expl>>");
            if (word == dictionary[i].Substring(0, explTagStart))
            {
                Console.WriteLine(dictionary[i].Substring(explTagStart + 8));
                return;
            }
        }
        Console.WriteLine("There is no explanation in the dictionary!");
    }
}