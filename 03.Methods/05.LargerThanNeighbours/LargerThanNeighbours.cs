/*
 * Problem 5. Larger than neighbours
 * Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
 */

using System;

class LargerThanNeighbours
{
    static bool IsMax(int[] array, int index)
    {
        if (index == 0)
        {
            if (array[0] > array[1])
            {
                return true; // ако първия елемент е по-голям от единствения си съсед, връща true; ако не трябва да е така, вложения if е излишен и винаги ще се връща false
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
                return true; // аналогично на посоченото по-горе
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

    static void Main()
    {
        int[] array = { 2, 3, 6, 2, 6, 2, 8, 7, 1, 4, 0, 6 };
        Console.Write("Please enter index of element: ");
        int index = int.Parse(Console.ReadLine());
        if (IsMax(array, index))
        {
            Console.WriteLine("The element of given index is larger than its two neighbours.");
        }
        else
        {
            Console.WriteLine("The element of given index isn't larger than its two neighbours.");
        }
    }
}