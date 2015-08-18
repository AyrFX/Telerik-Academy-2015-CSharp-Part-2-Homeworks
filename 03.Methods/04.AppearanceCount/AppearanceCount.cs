/*
 * Problem 4. Appearance count
 * Write a method that counts how many times given number appears in given array.
 * Write a test program to check if the method is workings correctly.
 */

using System;

class AppearanceCount
{
    static int CountAppearances(int[] array, int number)
    {
        int counter = 0;
        foreach(int element in array)
        {
            if (element == number)
            {
                counter++;
            }
        }
        return counter;
    }

    static void Main()
    {
        int[] array = { 2, 3, 6, 2, 6, 2, 8, 7, 1, 4, 0, 6 };
        Console.Write("Please enter number for chesk: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The given number appears {0} time(s) in the array.", CountAppearances(array, number));
    }
}