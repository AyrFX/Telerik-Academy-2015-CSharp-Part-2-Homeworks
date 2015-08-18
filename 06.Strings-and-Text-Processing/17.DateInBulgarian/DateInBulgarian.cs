/*
 * Problem 17. Date in Bulgarian
 * 
 * Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after
 * 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
 */

using System;
using System.Globalization;

class DateInBulgarian
{
    static void Main()
    {
        Console.WriteLine("Please enter date and time (d.M.yyyy HH:mm:ss): ");
        DateTime inputDateTime = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        inputDateTime = inputDateTime.AddHours(6).AddMinutes(30);
        Console.WriteLine("The time 6 hours and 30 minutes later is {0:d.M.yyyy HH:mm:ss}.", inputDateTime);
        CultureInfo culture = new CultureInfo("bg-BG");
        string dayOfWeek = culture.DateTimeFormat.GetDayName(inputDateTime.DayOfWeek);
        Console.WriteLine("The day of week is " + dayOfWeek);
    }
}