/*
 * Problem 5. Maximal increasing sequence
 * Write a program that finds the maximal increasing sequence in an array.
 * 
 * Example:
 * input 	            result
 * 3, 2, 3, 4, 2, 2, 4 	2, 3, 4
 */

using System;

class MaximalIncreaseSequence
{
    static void Main()
    {
        Console.Write("Please enter the size of the array: ");
        int arraySize = int.Parse(Console.ReadLine());
        int[] array = new int[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Please enter element {0} of the array: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int seqFirstElement = 0, lastIncrSeqLength = 1, seqMaxLength = 1, seqIncrLengthFirstElement = 0;
        for (int i = 1; i < arraySize; i++)
        {
            if (array[i - 1] < array[i])
            {
                lastIncrSeqLength++;
            }
            else
            {
                if (seqMaxLength < lastIncrSeqLength)
                {
                    seqMaxLength = lastIncrSeqLength;
                    seqIncrLengthFirstElement = seqFirstElement;
                }
                seqFirstElement = i;
                lastIncrSeqLength = 1;
            }
        }
        Console.Write("The maximal increasing sequence of element is: ");
        for (int i = seqIncrLengthFirstElement; i < seqIncrLengthFirstElement + seqMaxLength; i++)
        {
            Console.Write(array[i]);
            if (i != seqIncrLengthFirstElement + seqMaxLength - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}