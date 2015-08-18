/*
 * Problem 1. Leap year
 * Write a program that reads a year from the console and checks whether it is a leap one.
 * Use System.DateTime.
 */

using System;

class LeapYear
{
    static void Main()
    {
        Console.Write("Please enter year: ");
        int year = int.Parse(Console.ReadLine());
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine(year + " is leap year.");
        }
        else
        {
            Console.WriteLine(year + " is not leap year.");
        }
    }
}