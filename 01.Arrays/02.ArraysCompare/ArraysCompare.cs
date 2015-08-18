/*
 * Problem 2. Compare arrays
 * Write a program that reads two integer arrays from the console and compares them element by element.
 */

using System;

class ArraysCompare
{
    static void Main()
    {
        Console.Write("Please enter the size of the arrays: ");
        int arraysSize = int.Parse(Console.ReadLine());
        int[] array1 = new int[arraysSize];
        int[] array2 = new int[arraysSize];
        for (int i = 0; i < arraysSize; i++)
        {
            Console.Write("Please enter element {0} of the first array: ", i);
            array1[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arraysSize; i++)
        {
            Console.Write("Please enter element {0} of the second array: ", i);
            array2[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arraysSize; i++)
        {
            if (array1[i] != array2[i])
            {
                Console.WriteLine("The element {0} of array 1 differs element {0} of array 2!", i);
            }
            else
            {
                Console.WriteLine("The element {0} of array 1 is equal to element {0} of array 2!", i);
            }
        }
    }
}