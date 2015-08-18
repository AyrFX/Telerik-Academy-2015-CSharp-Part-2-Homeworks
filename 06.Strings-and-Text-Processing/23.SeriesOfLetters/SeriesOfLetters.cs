/*
 * Problem 23. Series of letters
 * 
 * Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
 * 
 * Example:
 * input 	                output
 * aaaaabbbbbcdddeeeedssaa 	abcdedsa
 */

using System;

class SeriesOfLetters
{
    static void Main()
    {
        Console.Write("Please enter text: ");
        string text = Console.ReadLine();
        int lastLenght;
        for (int i = 0; i < text.Length; i++)
        {
            do
            {
                lastLenght = text.Length;
                text = text.Replace(String.Format("{0}{1}", text[i], text[i]), String.Format("{0}", text[i]));
            }
            while (text.Length != lastLenght);
        }
        Console.WriteLine(text);
    }
}