/*
 * Problem 19. Dates from text in Canada
 * 
 * Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
 * Display them in the standard date format for Canada.
 */

using System;
using System.Text.RegularExpressions;
using System.Globalization;

class CanadianDatesExtract
{
    static void Main()
    {
        string text = "I don't know if it's 02.02.2015, 03.02.2015 or 02.03.2015";
        string[] words = text.Split(new[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries);
        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
        for (int i = 0; i < words.Length; i++)
        {
            if (Regex.IsMatch(words[i], @"\d+\.\d+\.\d+"))
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}