/*
 * Problem 4. Sub-string in text
 * 
 * Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
 * Example:
 * The target sub-string is in
 * The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight.
 * So we are drinking all the day. We will move out of it in 5 days.
 * The result is: 9
 */

using System;

class SubstringInText
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string subString = "in";
        int lastOccurrence = 0;
        int occurrences = 0;
        do
        {
            lastOccurrence = text.IndexOf(subString, Math.Min(lastOccurrence + 1, text.Length-1), StringComparison.CurrentCultureIgnoreCase);
            if (lastOccurrence > -1)
            {
                occurrences++;
            }
        }
        while (lastOccurrence > -1);
        Console.WriteLine(occurrences);
    }
}