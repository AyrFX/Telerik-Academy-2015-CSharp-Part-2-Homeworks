/*
 * Problem 7. Selection sort
 * Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
 * Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it
 * at the second position, etc.
 */

using System;

class SelectionSort
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
        int unsortedBorderIndex = 0, minValueIndex = 0;
        while (unsortedBorderIndex < n)
        {
            for (int i = unsortedBorderIndex; i < n; i++)
            {
                if (array[minValueIndex] > array[i])
                {
                    minValueIndex = i;
                }
            }
            int tmpValue = array[unsortedBorderIndex];
            array[unsortedBorderIndex] = array[minValueIndex];
            array[minValueIndex] = tmpValue;
            unsortedBorderIndex++;
        }
        Console.WriteLine("Sorted array: ");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Element [{0}] = {1}", i, array[i]);
        }
    }
}