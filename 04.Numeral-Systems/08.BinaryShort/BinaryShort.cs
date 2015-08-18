/*
 * Problem 8. Binary short
 * Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
 */

using System;

class BinaryShort
{
    static void Main()
    {
        Console.Write("Please enter signed short number: ");
        int shortNumber = short.Parse(Console.ReadLine());
        char sign;
        if (shortNumber < 0)
        {
            sign = '1';
        }
        else
        {
            sign = '0';
        }
        string binNumber = "";
        if (shortNumber < 0)
        {
            shortNumber = 32768 - Math.Abs(shortNumber);
        }
        shortNumber = shortNumber;
        do
        {
            binNumber = shortNumber % 2 + binNumber;
            shortNumber = shortNumber / 2;
        }
        while (shortNumber > 0);
        binNumber = sign + binNumber.PadLeft(15, '0');
        Console.WriteLine("The binary representation of the number is: " + binNumber);
    }
}