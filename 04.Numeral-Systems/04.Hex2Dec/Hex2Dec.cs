/*
 * Problem 4. Hexadecimal to decimal
 * Write a program to convert hexadecimal numbers to their decimal representation.
 */

using System;

class Hex2Dec
{
    static void Main()
    {
        Console.Write("Please enter hexadecimal number: ");
        string hexNumber = Console.ReadLine();
        int decNumber = 0;
        byte digit;
        hexNumber = hexNumber.ToUpper();
        for (int i = hexNumber.Length - 1, j = 0; i >= 0; i--, j++)
        {
            switch (hexNumber[i])
            {
                case 'A':
                    digit = 10;
                    break;
                case 'B':
                    digit = 11;
                    break;
                case 'C':
                    digit = 12;
                    break;
                case 'D':
                    digit = 13;
                    break;
                case 'E':
                    digit = 14;
                    break;
                case 'F':
                    digit = 15;
                    break;
                default:
                    digit = (byte)char.GetNumericValue(hexNumber[i]);
                    break;
            }
            decNumber += digit * (int)Math.Pow(16, j);
        }
        Console.WriteLine("The decimal representation of the number is: " + decNumber);
    }
}