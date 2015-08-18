/*
 * Problem 1. Decimal to binary
 * Write a program to convert decimal numbers to their binary representation.
 */

using System;

class Dec2Bin
{
    static void Main()
    {
        Console.Write("Please enter decimal number: ");
        int decNumber = int.Parse(Console.ReadLine());
        string binNumber = "";
        do
        {
            binNumber = decNumber % 2 + binNumber;
            decNumber = decNumber / 2;
        }
        while (decNumber > 0);
        Console.WriteLine("The binary representation of the number is: " + binNumber);
    }
}