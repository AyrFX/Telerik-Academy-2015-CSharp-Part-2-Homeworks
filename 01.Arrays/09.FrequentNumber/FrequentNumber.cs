/*
 * Problem 9. Frequent number
 * Write a program that finds the most frequent number in an array.
 * 
 * Example:
 * input 	                                result
 * 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 	4 (5 times)
 */

using System;

class FrequentNumber
{
    static void Main()
    {
        Console.Write("Please enter the length of the array (elements): ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Please enter {0}-th element of the array: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        //int[] array = new int[] {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3};
        int counter = 0, lastMaxCount = 0, elementIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    counter++;
                }
            }
            if (lastMaxCount < counter)
            {
                lastMaxCount = counter;
                elementIndex = i;
            }
            counter = 0;
        }
        Console.WriteLine("The most frequent element is {0}({1} times)", array[elementIndex], lastMaxCount);
    }
}