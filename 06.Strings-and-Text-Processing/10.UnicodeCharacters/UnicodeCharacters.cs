/*
 * Problem 10. Unicode characters
 * 
 * Write a program that converts a string to a sequence of C# Unicode character literals.
 * Use format strings.
 * Example:
 * input 	output
 * Hi!      \u0048\u0069\u0021
 */

using System;

class UnicodeCharacters
{
    static void Main()
    {
        string inputString = "Hi!";
        string outputString = "";
        foreach (char s in inputString)
        {
            outputString = outputString + String.Format("\\u{0:x4}", (int)s);
        }
        Console.WriteLine(outputString);
    }
}