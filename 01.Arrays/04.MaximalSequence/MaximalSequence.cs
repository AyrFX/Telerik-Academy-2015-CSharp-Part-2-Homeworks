/*
 * Problem 4. Maximal sequence
 * Write a program that finds the maximal sequence of equal elements in an array.
 * 
 * Example:
 * input 	                        result
 * 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 	2, 2, 2
 */

using System;

class MaximalSequence
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
        int seqFirstElement = 0, lastMaxSeqLength = 1, seqMaxLength = 1, seqMaxLengthFirstElement = 0;
        for (int i = 1; i < arraySize; i++)
        {
            if (array[seqFirstElement] == array[i])
            {
                lastMaxSeqLength++;
            }
            else
            {
                if (seqMaxLength < lastMaxSeqLength)
                {
                    seqMaxLength = lastMaxSeqLength;
                    seqMaxLengthFirstElement = seqFirstElement;
                }
                seqFirstElement = i;
                lastMaxSeqLength = 1;
            }
        }
        Console.Write("The maximal sequence of equal element is: ");
        for (int i = seqMaxLengthFirstElement; i < seqMaxLengthFirstElement + seqMaxLength; i++)
        {
            Console.Write(array[i]);
            if (i != seqMaxLengthFirstElement + seqMaxLength -1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}