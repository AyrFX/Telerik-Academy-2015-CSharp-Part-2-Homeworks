/*
 * Problem 11. Binary search
 * Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
 */

using System;

class BinarySearch
{
    static void Main()
    {
        int key = 54;
        int[] array = new int[] { 4, 645, 21, 87, 2, 7, 90, 2, 5, 2, 8, 54, 85, 4 };
        Array.Sort(array);
        Console.Write("Sorted array is: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i != array.Length)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
        int firstSearchIndex = 0, lastSearchIndex = array.Length, middle = -1;
        while (middle != 0) //(firstSearchIndex != lastSearchIndex)
        {
            middle = (lastSearchIndex - firstSearchIndex) / 2;
            if (array[middle + firstSearchIndex] == key)
            {
                Console.WriteLine("The index of element {0} is {1}", key, middle + firstSearchIndex);
                return;
            }
            else if (key < array[middle + firstSearchIndex])
            {
                lastSearchIndex -= middle;
            }
            else
            {
                firstSearchIndex += middle;
            }
        }
        Console.WriteLine("There isn't element {0}", key);
    }
}