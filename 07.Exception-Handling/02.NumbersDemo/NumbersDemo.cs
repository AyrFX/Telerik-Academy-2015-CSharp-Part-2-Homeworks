/*
 * Problem 2. Enter numbers
 * Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
 * If an invalid number or non-number text is entered, the method should throw an exception.
 * Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100 
 */

using System;

class NumbersDemo
{
    static int ReadNumber(int start, int end)
    {
        int number;
        try
        {
            number = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            throw new FormatException();
        }
        if (number <= start || number >= end)
        {
            throw new ArgumentOutOfRangeException();
        }
        return number;
    }

    static void Main()
    {
        Console.WriteLine("Please enter a sequence of ascending ordered numbers:");
        int startNumber = 1, endNumber = 100, currentNumber = 0;
        for (int i = startNumber; i < endNumber; i++)
        {
            try
            {
                currentNumber = ReadNumber(startNumber, endNumber);
            }
            catch (FormatException)
            {
                Console.WriteLine("The entered number is invalid!!!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The entered number is out of range [{0}..{1}]!!!", startNumber, endNumber);
            }
            startNumber = currentNumber;
        }
    }
}