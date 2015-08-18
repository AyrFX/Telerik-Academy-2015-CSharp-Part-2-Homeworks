/*
 * Problem 5. Workdays
 * Write a method that calculates the number of workdays between today and given date, passed as parameter.
 * Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
 */

using System;

class Workdays
{
    static void Main()
    {
        DateTime[] publicHolidays = new DateTime[]
        {
            new DateTime(2015, 03, 02),
            new DateTime(2015, 03, 03),
        };
        DateTime startDate = DateTime.Today;
        Console.Write("Please enter date: ");
        DateTime endDate = new DateTime();
        DateTime.TryParse(Console.ReadLine(), out endDate);
        if (DateTime.Compare(startDate, endDate) > 0)
        {
            Console.WriteLine("The date must be later than today!");
            return;
        }
        Console.WriteLine("There are {0} workdays from today to {1}", WorkdaysBetween(startDate, endDate, publicHolidays), endDate.ToString("d"));
    }

    static int WorkdaysBetween(DateTime startDate, DateTime endDate, DateTime[] publicHolidays)
    {
        int workdaysCounter = 0;
        do
        {
            if (startDate.DayOfWeek == DayOfWeek.Monday || startDate.DayOfWeek == DayOfWeek.Tuesday || startDate.DayOfWeek == DayOfWeek.Wednesday ||
                startDate.DayOfWeek == DayOfWeek.Thursday || startDate.DayOfWeek == DayOfWeek.Friday)
            {
                workdaysCounter++;
                for (int i = 0; i < publicHolidays.Length; i++)
                {
                    if (publicHolidays[i] == startDate)
                    {
                        workdaysCounter--;
                    }
                }
            }
            startDate = startDate.AddDays(1);
        }
        while (DateTime.Compare(startDate, endDate) < 0);
        return workdaysCounter;
    }
}