/*
 * Problem 6. First larger than neighbours
 * Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
 * Use the method from the previous exercise.
 */

using System;

class FirstLargerThanNeighbours
{
    static bool IsMax(int[] array, int index)
    {
        if (index == 0)
        {
            if (array[0] > array[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (index == array.Length - 1)
        {
            if (array[array.Length - 1] > array[array.Length - 2])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            if ((array[index] > array[index - 1]) && (array[index] > array[index + 1]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    static int FirstMaxElement(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (IsMax(array, i))
            {
                return i;
            }
        }
        return -1;
    }

    static void Main()
    {
        int[] array = { 2, 3, 6, 2, 6, 2, 8, 7, 1, 4, 0, 6 };
        
        if (FirstMaxElement(array) != -1)
        {
            Console.WriteLine("The first element of that is larger than its neighbours is " + FirstMaxElement(array));
        }
        else
        {
            Console.WriteLine("There is no element that is larger than its neighbours.");
        }
    }
}