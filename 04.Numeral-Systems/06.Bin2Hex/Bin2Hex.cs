/*
 * Problem 6. binary to hexadecimal
 * Write a program to convert binary numbers to hexadecimal numbers (directly).
 */

using System;

class Bin2Hex
{
    static void Main()
    {
        Console.Write("Please enter binary number: ");
        string binNumber = Console.ReadLine();
        while (binNumber.Length % 4 != 0)
        {
            binNumber = "0" + binNumber;
        }
        string hexNumber = "";
        string digit;
        for (int i = binNumber.Length - 1; i >= 0; i = i - 4)
        {
            digit = binNumber.Substring(i - 3, 4);
            switch (digit)
            {
                case "0000":
                    digit = "0";
                    break;
                case "0001":
                    digit = "1";
                    break;
                case "0010":
                    digit = "2";
                    break;
                case "0011":
                    digit = "3";
                    break;
                case "0100":
                    digit = "4";
                    break;
                case "0101":
                    digit = "5";
                    break;
                case "0110":
                    digit = "6";
                    break;
                case "0111":
                    digit = "7";
                    break;
                case "1000":
                    digit = "8";
                    break;
                case "1001":
                    digit = "9";
                    break;
                case "1010":
                    digit = "A";
                    break;
                case "1011":
                    digit = "B";
                    break;
                case "1100":
                    digit = "C";
                    break;
                case "1101":
                    digit = "D";
                    break;
                case "1110":
                    digit = "E";
                    break;
                case "1111":
                    digit = "F";
                    break;
                default:
                    digit = "0";
                    break;
            }
            hexNumber = digit + hexNumber;
        }
        Console.WriteLine("The hexadecimal representation of the number is: " + hexNumber);
    }
}