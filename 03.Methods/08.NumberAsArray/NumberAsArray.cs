/*
 * Problem 8. Number as array
 * Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit;
 * the last digit is kept in arr[0]).
 * Each of the numbers that will be added could have up to 10 000 digits.
 */

using System;
using System.Numerics;

class NumberAsArray
{
    static BigInteger sumNumbers(int[] first, int[] second)
    {
        int sum = 0;
        for (int i = 0; i < Math.Max(first.Length, second.Length); i++) //по условие, последната цифра се пази в елемент с индекс 0
        {
            if (i < first.Length)
            {
                sum += first[i] * (int)Math.Pow(10, i);
            }
            if (i < second.Length)
            {
                sum += second[i] * (int)Math.Pow(10, i);
            }
        }
        return sum;
    }

    static void Main()
    {
        int[] firstNumber = { 2, 3, 6 };
        int[] secondNumber = { 9, 7, 2 };
        Console.WriteLine("The sum of the numbers is: " + sumNumbers(firstNumber, secondNumber));
    }
}