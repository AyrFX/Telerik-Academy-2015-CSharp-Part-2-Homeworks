/*
 * Problem 24. Order words
 * 
 * Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
 */

using System;

class WordsOrder
{
    static void Main()
    {
        Console.Write("Please enter list of words separated by spaces: ");
        string text = Console.ReadLine();
        string[] words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(words);
        Console.WriteLine(String.Join(" ", words));
    }
}