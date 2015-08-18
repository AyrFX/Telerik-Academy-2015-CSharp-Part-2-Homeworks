/*
 * Problem 16. Date difference
 * 
 * Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
 * 
 * Example:
 * Enter the first date: 27.02.2006
 * Enter the second date: 3.03.2006
 * Distance: 4 days
 */

using System;
using System.Globalization;

class DateDifference
{
    static void Main()
    {
        Console.Write("Please enter first date (d.M.yyyy): ");
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
        Console.Write("Please enter second date (d.M.yyyy): ");
        DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine("Distance: " + Math.Abs((secondDate - firstDate).Days) + " days");
    }
}