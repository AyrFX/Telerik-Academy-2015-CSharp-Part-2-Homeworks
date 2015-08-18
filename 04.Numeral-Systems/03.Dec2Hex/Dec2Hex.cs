/*
 * Problem 3. Decimal to hexadecimal
 * Write a program to convert decimal numbers to their hexadecimal representation.
 */

using System;

class Dec2Hex
{
    static void Main()
    {
        Console.Write("Please enter decimal number: ");
        int decNumber = int.Parse(Console.ReadLine());
        string hexNumber = "";
        int reminder;
        do
        {
            reminder = decNumber % 16;
            switch (reminder)
            {
                case 10:
                    hexNumber = "A" + hexNumber;
                    break;
                case 11:
                    hexNumber = "B" + hexNumber;
                    break;
                case 12:
                    hexNumber = "C" + hexNumber;
                    break;
                case 13:
                    hexNumber = "D" + hexNumber;
                    break;
                case 14:
                    hexNumber = "E" + hexNumber;
                    break;
                case 15:
                    hexNumber = "F" + hexNumber;
                    break;
                default:
                    hexNumber = reminder + hexNumber;
                    break;
            }
            decNumber = decNumber / 16;
        }
        while (decNumber > 0);
        Console.WriteLine("The hexadecimal representation of the number is: " + hexNumber);
    }
}