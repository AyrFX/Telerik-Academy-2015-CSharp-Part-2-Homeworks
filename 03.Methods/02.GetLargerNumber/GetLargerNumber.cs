/*
 * Problem 2. Get largest number
 * Write a method GetMax() with two parameters that returns the larger of two integers.
 * Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
 */

using System;

class GetLargerNumber
{
    static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    static void Main()
    {
        Console.Write("Please, enter number a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please, enter number b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Please, enter number c: ");
        int c = int.Parse(Console.ReadLine());
        int max = GetMax(GetMax(a, b), GetMax(a, c));
        Console.WriteLine("The largest number is " + max);
    }
}