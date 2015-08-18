/*
 * Problem 8. Maximal sum
 * Write a program that finds the sequence of maximal sum in given array.
 * 
 * Example:
 * input 	                            result
 * 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 	2, -1, 6, 4
 * 
 * Can you do it with only one loop (with single scan through the elements of the array)?
 */

using System;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Please enter the length of the sequence (elements): ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Please enter the length of the array (elements): ");
        int n = int.Parse(Console.ReadLine());
        if (k > n)
        {
            Console.WriteLine("The length of the array must be greather or equal to the length of the sequence!");
            return;
        }
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Please enter {0}-th element of the array: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        /*int k = 4;
        int n = 10;
        int[] array = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };*/
        int seqFirstIndex = 0;
        int seqMaxSum = 0;
        int seqCurrentSum = 0;
        for (int i = 0; i < n; i++)
        {
            if (i < k)
            {
                seqCurrentSum += array[i];
                seqMaxSum = seqCurrentSum;
                continue;
            }
            seqCurrentSum -= array[i - k];
            seqCurrentSum += array[i];
            if (seqCurrentSum > seqMaxSum)
            {
                seqFirstIndex = i - k + 1;
                seqMaxSum = seqCurrentSum;
            }
        }
        Console.Write("The sequence with the maximal sum is: ");
        for (int i = seqFirstIndex; i < seqFirstIndex + k; i++)
        {
            Console.Write(array[i]);
            if (i != seqFirstIndex + k - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}