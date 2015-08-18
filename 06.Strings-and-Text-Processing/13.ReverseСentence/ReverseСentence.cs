/*
 * Problem 13. Reverse sentence
 * 
 * Write a program that reverses the words in given sentence.
 * Example:
 * input 	                                output
 * C# is not C++, not PHP and not Delphi! 	Delphi not and PHP, not C++ not is C#!
 */

using System;
using System.Collections.Generic;

class ReverseСentence
{
    static void Main()
    {
        string text = "C# is not C++, not PHP and not Delphi!";
        string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        char[] signs = new char[] { '.', ',', '!', '?' };
        Array.Reverse(words);
        for (int i = 0; i < signs.Length - 1; i++)
        {
            for (int j = 0; j < words.Length - 1; j++)
            {
                if (words[j].IndexOf(signs[i]) > -1)
                {
                    words[j] = words[j].Remove(words[j].Length - 2);
                    words[words.Length - j - 1] = words[words.Length - j - 1] + signs[i];
                }
            }
        }
        Console.WriteLine(String.Join(" ", words));
    }
}