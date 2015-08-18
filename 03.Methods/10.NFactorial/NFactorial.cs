/*
 * Problem 10. N Factorial
 * Write a program to calculate n! for each n in the range [1..100].
 * 
 * Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
 */

using System;
using System.Numerics;

class NFactorial
{
    static BigInteger Factorial(BigInteger n)
    {
        if (n == 1)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }

    static void Main()
    {
        for(int i = 1; i <= 100; i++)
        {
            Console.WriteLine("{0}! = {1}", i, Factorial(i));
        }
    }
}