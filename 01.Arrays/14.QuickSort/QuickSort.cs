/*
 * Problem 14. Quick sort
 * Write a program that sorts an array of strings using the Quick sort algorithm.
 */

using System;
using System.Collections.Generic;

class QuickSort
{
    static void Main()
    {
        List<string> listOfStrings = new List<string> {"John", "Ray", "Herbert", "George", "Bill", "Maxim", "Peter"};
        int shift = 0;
        for (int i = 0; i < listOfStrings.Count; i++)
        {
            for (int j = 0; j < listOfStrings.Count; j++)
            {
                if (i + shift == j)
                {
                    continue;
                }
                if ((i + shift < j) && (String.Compare(listOfStrings[i + shift], listOfStrings[j], false) > 0))
                {
                    listOfStrings.Insert(i, listOfStrings[j]);
                    listOfStrings.RemoveAt(j+1);
                    shift++;
                }
                if ((i + shift > j) && (String.Compare(listOfStrings[i + shift], listOfStrings[j], false) < 0))
                {
                    listOfStrings.Add(listOfStrings[j]);
                    listOfStrings.RemoveAt(j);
                }
            }
            if (shift != 0)
            {
                shift = 0;
            }
        }
        for (int i = 0; i < listOfStrings.Count; i++)
        {
            Console.Write(listOfStrings[i]);
            if (i != listOfStrings.Count - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}