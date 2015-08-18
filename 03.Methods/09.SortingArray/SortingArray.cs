/*
 * Problem 9. Sorting array
 * Write a method that return the maximal element in a portion of array of integers starting at given index.
 * Using it write another method that sorts an array in ascending / descending order.
 */

using System;

class SortingArray
{
    static int GetMax(int[] array, int startIndex)
    {
        int maxElement = int.MinValue;
        for (int i = startIndex; i < array.Length; i++)
        {
            if (array[i] > maxElement)
            {
                maxElement = array[i];
            }
        }
        return maxElement;
    }

    static int[] SortAscending(int[] array)
    {
        int[] resultArray = new int[array.Length];
        int max = int.MinValue;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            max = GetMax(array, 0);
            resultArray[i] = max;
            array[Array.IndexOf(array, max)] = int.MinValue;
        }
        return resultArray;
    }

    static int[] SortDescending(int[] array)
    {
        int[] resultArray = new int[array.Length];
        int max = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            max = GetMax(array, 0);
            resultArray[i] = max;
            array[Array.IndexOf(array, max)] = int.MinValue;
        }
        return resultArray;
    }

    static void Main()
    {
        int[] array = {123, 1435, 124, 14, 10, 13};
        int[] resultsArray = new int[array.Length];
        resultsArray = SortAscending(array);
        Console.WriteLine("Ascending sorted Array: ");
        for (int i = 0; i < resultsArray.Length; i++)
        {
            Console.Write(resultsArray[i]);
            if (i < resultsArray.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
        resultsArray = SortDescending(resultsArray);
        Console.WriteLine("Descending sorted Array: ");
        for (int i = 0; i < resultsArray.Length; i++)
        {
            Console.Write(resultsArray[i]);
            if (i < resultsArray.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}