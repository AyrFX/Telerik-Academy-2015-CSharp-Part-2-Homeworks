/*
 * Problem 7. Reverse number
 * Write a method that reverses the digits of given decimal number.
 * 
 * Example:
 * input 	output
 * 256 	    652
 * 123.45 	54.321
 */

using System;

class ReverseNumber
{
    static double Reverse(double inputNumber)
    {
        string numberAsString = Convert.ToString(inputNumber);
        string reversedNumber = "";
        for (int i = 0; i < numberAsString.Length; i++)
        {
            reversedNumber = numberAsString[i] + reversedNumber;
        }
        return double.Parse(reversedNumber);
    }

    static void Main()
    {
        Console.Write("Please enter decimal number: ");
        double decNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Reversed number is: " + Reverse(decNumber));
    }
}