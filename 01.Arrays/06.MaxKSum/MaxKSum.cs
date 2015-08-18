/*
 * Problem 6. Maximal K sum
 * Write a program that reads two integer numbers N and K and an array of N elements from the console.
 * Find in the array those K elements that have maximal sum.
 */

using System;
using System.Linq;

class MaxKSum
{
    static void Main()
    {
        Console.Write("Please enter K: ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Please enter N: ");
        int n = int.Parse(Console.ReadLine());
        if (k > n)
        {
            Console.WriteLine("N must be greater or equal to K!");
            return;
        }
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Please enter {0}-th element of the array: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        int sum = 0;
        for (int i = n-1, j = 1; i > k; i--, j++)
        {
            Console.WriteLine("Element {0} = {1}", j, array[i]);
            sum += array[i];
        }
        Console.WriteLine("The sum of the elements is {0}", sum);
    }
}