/*
 * Problem 7. One system to any other
    Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
 */

using System;

class SystemConvertion
{
    static void Main()
    {
        Console.Write("Please enter the base (s) of input number: ");
        byte inputBase = byte.Parse(Console.ReadLine());
        if (inputBase < 2 || inputBase > 16)
        {
            Console.WriteLine("Wrong base of the input number!");
            return;
        }
        Console.Write("Please enter number to convert: ");
        string inputNumber = Console.ReadLine();
        Console.Write("Please enter the base (d) of output number: ");
        byte outputBase = byte.Parse(Console.ReadLine());
        if (outputBase < 2 || outputBase > 16)
        {
            Console.WriteLine("Wrong base of the output number!");
            return;
        }
        Console.WriteLine("The converted number is: " + FromDec(ToDec(inputNumber, inputBase), outputBase));
    }

    static int ToDec(string inputNumber, int inputBase)
    {
        int decNumber = 0;
        if (inputBase < 10)
        {
            for (int i = inputNumber.Length - 1, j = 0; i >= 0; i--, j++)
            {
                decNumber += (int)char.GetNumericValue(inputNumber[i]) * (int)Math.Pow(inputBase, j);
            }
            return decNumber;
        }
        else if (inputBase > 10)
        {
            byte digit;
            inputNumber = inputNumber.ToUpper();
            for (int i = inputNumber.Length - 1, j = 0; i >= 0; i--, j++)
            {
                switch (inputNumber[i])
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
                        digit = (byte)char.GetNumericValue(inputNumber[i]);
                        break;
                }
                decNumber += digit * (int)Math.Pow(inputBase, j);
            }
            return decNumber;
        }
        else
        {
            return int.Parse(inputNumber);
        }
    }

    static string FromDec(int inputNumber, int outputBase)
    {
        string outputNumber = "";
        int reminder;
        do
        {
            reminder = inputNumber % outputBase;
            switch (reminder)
            {
                case 10:
                    outputNumber = "A" + outputNumber;
                    break;
                case 11:
                    outputNumber = "B" + outputNumber;
                    break;
                case 12:
                    outputNumber = "C" + outputNumber;
                    break;
                case 13:
                    outputNumber = "D" + outputNumber;
                    break;
                case 14:
                    outputNumber = "E" + outputNumber;
                    break;
                case 15:
                    outputNumber = "F" + outputNumber;
                    break;
                default:
                    outputNumber = reminder + outputNumber;
                    break;
            }
            inputNumber = inputNumber / outputBase;
        }
        while (inputNumber > 0);
        return outputNumber;
    }
}