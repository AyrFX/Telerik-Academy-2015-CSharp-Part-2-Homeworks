/*
 * Problem 4. Binary search
 * Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method
 * Array.BinSearch() finds the largest number in the array which is ≤ K.
 */

using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Please enter N: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Please enter {0}-th element of the array: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Please enter K: ");
        int k = int.Parse(Console.ReadLine());
        Array.Sort(array);
        while (Array.BinarySearch(array, k) < 0)
        {
            k--;
        }
        Console.WriteLine("The largest number ≤ K is: " + k);
    }
}