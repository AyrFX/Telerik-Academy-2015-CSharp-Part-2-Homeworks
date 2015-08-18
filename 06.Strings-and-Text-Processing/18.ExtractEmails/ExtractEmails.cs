/*
 * Problem 18. Extract e-mails
 * 
 * Write a program for extracting all email addresses from given text.
 * All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
 */

using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string text = "Usual contect address is office@firm.com, but companies use also sales@firm.com, contact@firm.com, jobs@firm.com and other.";
        string[] words = text.Split(new[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length; i++)
        {
            if (Regex.IsMatch(words[i], @"\w+@\w+\.\w+"))
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}