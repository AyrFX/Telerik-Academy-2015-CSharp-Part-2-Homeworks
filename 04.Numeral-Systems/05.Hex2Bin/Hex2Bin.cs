/*
 * Problem 5. Hexadecimal to binary
 * Write a program to convert hexadecimal numbers to binary numbers (directly).
 */

using System;

class Hex2Bin
{
    static void Main()
    {
        Console.Write("Please enter hexadecimal number: ");
        string hexNumber = Console.ReadLine();
        string binNumber = "";
        string digit;
        hexNumber = hexNumber.ToUpper();
        for (int i = hexNumber.Length - 1; i >= 0; i--)
        {
            switch (hexNumber[i])
            {
                case '0':
                    digit = "0000";
                    break;
                case '1':
                    digit = "0001";
                    break;
                case '2':
                    digit = "0010";
                    break;
                case '3':
                    digit = "0011";
                    break;
                case '4':
                    digit = "0100";
                    break;
                case '5':
                    digit = "0101";
                    break;
                case '6':
                    digit = "0110";
                    break;
                case '7':
                    digit = "0111";
                    break;
                case '8':
                    digit = "1000";
                    break;
                case '9':
                    digit = "1001";
                    break;
                case 'A':
                    digit = "1010";
                    break;
                case 'B':
                    digit = "1011";
                    break;
                case 'C':
                    digit = "1100";
                    break;
                case 'D':
                    digit = "1101";
                    break;
                case 'E':
                    digit = "1110";
                    break;
                case 'F':
                    digit = "1111";
                    break;
                default:
                    digit = "0000";
                    break;
            }
            binNumber = digit  + binNumber;
        }
        Console.WriteLine("The binary representation of the number is: " + binNumber);
    }
}