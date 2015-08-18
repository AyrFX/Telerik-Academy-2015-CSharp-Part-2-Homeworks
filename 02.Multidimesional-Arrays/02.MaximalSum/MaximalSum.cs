/*
 * Problem 2. Maximal sum
 * Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
 */

using System;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Please enter m: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        if ((m < 3) || (n < 3))
        {
            Console.WriteLine("The matrix must be at least 3 x 3: ");
            return;
        }
        int[,] matrix = new int[m, n];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("Please enter element [{0}, {1}]: ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        int maxSum = int.MinValue, currentSum = 0;
        int maxSumX = 0, maxSumY = 0;
        for (int i = 0; i < matrix.GetLength(0) - 2; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 2; j++)
            {
                currentSum = matrix[i, j] + matrix[i + 1, j] + matrix[i + 2, j] +
                         matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                         matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxSumX = i;
                    maxSumY = j;
                }
            }
        }
        Console.WriteLine("The square with max sum of elements is: ");
        for (int i = maxSumX; i < maxSumX + 3; i++)
        {
            for (int j = maxSumY; j < maxSumY + 3; j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
                if (j != matrix.GetLength(1) - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("The sum of elements = " + maxSum);
    }
}