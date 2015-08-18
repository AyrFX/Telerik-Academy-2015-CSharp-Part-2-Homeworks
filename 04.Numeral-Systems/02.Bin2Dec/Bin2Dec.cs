/*
 * Problem 2. Binary to decimal
 * Write a program to convert binary numbers to their decimal representation.
 */

using System;

class Bin2Dec
{
    static void Main()
    {
        Console.Write("Please enter binary number: ");
        string binNumber = Console.ReadLine();
        int decNumber = 0;
        for (int i = binNumber.Length - 1, j = 0; i >= 0; i--, j++)
        {
            decNumber += (int)char.GetNumericValue(binNumber[i]) * (int)Math.Pow(2, j);
        }
        Console.WriteLine("The decimal representation of the number is: " + decNumber);
    }
}