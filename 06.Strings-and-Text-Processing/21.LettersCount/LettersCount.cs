/*
 * Problem 21. Letters count
 * Write a program that reads a string from the console and prints all different letters in the string along with information how many
 * times each letter is found.
 */

using System;
using System.Collections.Generic;

class LettersCount
{
    static void Main()
    {
        Console.Write("Please enter text: ");
        string text = Console.ReadLine();
        int textLength;
        char symbol;
        do
        {
            textLength = text.Length;
            symbol = text[0];
            text = text.Replace(String.Format("{0}", symbol), "");
            Console.WriteLine("The letter \"{0}\" is found {1} times", symbol, textLength - text.Length);
        }
        while (text.Length > 0);
    }
}