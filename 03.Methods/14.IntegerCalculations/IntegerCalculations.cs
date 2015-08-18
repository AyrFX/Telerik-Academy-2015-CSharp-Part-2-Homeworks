/*
 * Problem 14. Integer calculations
 * Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
 * Use variable number of arguments.
 */

using System;

class IntegerCalculations
{
    static void Main()
    {
        int[] intArray = { 24, 574, 5, 47, 768, 34, -53, -3453, 34, -45 };
        Console.WriteLine("Minimum: " + IntMin(intArray));
        Console.WriteLine("Maximum: " + IntMax(intArray));
        Console.WriteLine("Average: " + IntAvg(intArray));
        Console.WriteLine("Sum: " + IntSum(intArray));
        Console.WriteLine("Product: " + IntProduct(intArray));
    }

    static int IntMin(params int[] array)
    {
        int min = int.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i];
            }
        }
        return min;
    }

    static int IntMax(params int[] array)
    {
        int max = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
            }
        }
        return max;
    }

    static double IntAvg(params int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return (double)sum / array.Length;
    }

    static int IntSum(params int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    static int IntProduct(params int[] array)
    {
        int product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;
    }
}