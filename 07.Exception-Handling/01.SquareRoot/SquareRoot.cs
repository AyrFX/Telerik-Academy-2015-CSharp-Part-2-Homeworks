/*
 * Problem 1. Square root
 * Write a program that reads an integer number and calculates and prints its square root.
 * If the number is invalid or negative, print Invalid number.
 * In all cases finally print Good bye.
 * Use try-catch-finally block.
 */

using System;

class SquareRoot
{
    static void Main()
    {
        Console.Write("Please enter integer number: ");
        int number;
        try
        {
            number = int.Parse(Console.ReadLine());
            if (number < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            Console.WriteLine("The square root of {0} is {1}", number, Math.Sqrt(number));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid integer number!!!");
            return;
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The number is out of range!");
            return;
        }
        finally
        {
            Console.WriteLine("Goodbye!!!");
        }
    }
}
