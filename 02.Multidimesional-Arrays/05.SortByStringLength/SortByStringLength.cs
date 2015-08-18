/*
 * Problem 5. Sort by string length
 * You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters
 * composing them).
 */

using System;

class SortByStringLength
{
    static void Main()
    {
        Console.Write("Please enter N: ");
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Please enter {0}-th element of the array: ", i);
            array[i] = Console.ReadLine();
        }
        string tempString;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i].Length > array[j].Length)
                {
                    tempString = array[i];
                    array[i] = array[j];
                    array[j] = tempString;
                }
            }
        }
        Console.Write("The sorted array is: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i != array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}