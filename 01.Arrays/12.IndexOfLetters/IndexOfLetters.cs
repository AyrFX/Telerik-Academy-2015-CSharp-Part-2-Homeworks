/*
 * Problem 12. Index of letters
 * Write a program that creates an array containing all letters from the alphabet (A-Z).
 * Read a word from the console and print the index of each of its letters in the array.
 */

using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] array = new char[] {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V',
                               'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
                               's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        Console.WriteLine("Please enter a word: ");
        string word = Console.ReadLine();
        for (int i = 0; i < word.Length; i++)
        {
            Console.WriteLine("Letter {0} has index {1} in the array.", word[i], Array.IndexOf(array, word[i]));
        }
    }
}