/*
 * Problem 3. Compare char arrays
 * Write a program that compares two char arrays lexicographically (letter by letter).
 */

using System;

class CharArraysCompare
{
    static void Main()
    {
        Console.Write("Please enter the size of the arrays: ");
        int arraysSize = int.Parse(Console.ReadLine());
        char[] array1 = new char[arraysSize];
        char[] array2 = new char[arraysSize];
        for (int i = 0; i < arraysSize; i++)
        {
            Console.Write("Please enter element {0} of the first array: ", i);
            array1[i] = char.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arraysSize; i++)
        {
            Console.Write("Please enter element {0} of the second array: ", i);
            array2[i] = char.Parse(Console.ReadLine());
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