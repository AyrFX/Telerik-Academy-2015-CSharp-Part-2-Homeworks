/*
 * Problem 20. Palindromes
 * 
 * Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
 */

using System;

class Palindromes
{
    static void Main()
    {
        string text = "A palindrome is a word, phrase, number, or other sequence of characters which reads the same backward or forward. noon, civic, radar, level, rotor, kayak, reviver, racecar, redder, madam, and refer.";
        string[] words = text.Split(new[] {" ", ", ", ". ", "."}, StringSplitOptions.RemoveEmptyEntries);
        bool IsPalindrome = true;
        for (int i = 0; i < words.Length; i++)
		{
			 for (int j = 0; j  < words[i].Length / 2; j++)
			{
			    if (words[i][j] != words[i][words[i].Length - 1 - j])
                {
                    IsPalindrome = false;
                    break;
                }
			}
            if (IsPalindrome)
            {
                Console.WriteLine(words[i]);
            }
            IsPalindrome = true;
		}
    }
}