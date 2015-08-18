/*
 * Problem 1. Fill the matrix
 * Write a program that fills and prints a matrix of size (n, n) as shown below:
 * 
 * Example for n=4:
 * a)
 *  1 	5 	9 	13
 *  2 	6 	10 	14
 *  3 	7 	11 	15
 *  4 	8 	12 	16
 * b)
 *  1 	8 	9 	16
 *  2 	7 	10 	15
 *  3 	6 	11 	14
 *  4 	5 	12 	13
 * c)
 *  7 	11 	14 	16
 *  4 	8 	12 	15
 *  2 	5 	9 	13
 *  1 	3 	6 	10
 * d)*	
 *  1	12 	11 	10
 *  2 	13 	16 	9
 *  3 	14 	15 	8
 *  4 	5 	6 	7
 */

using System;

class FillTheMatrix
{
    static void Main()
    {
        Console.Write("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        int counter = 1;
        // Fill A
        int[,] arrayA = new int[n, n];
        for (int i = 0; i < arrayA.GetLength(0); i++)
        {
            for (int j = 0; j < arrayA.GetLength(1); j++)
            {
                arrayA[j, i] = counter;
                counter++;
            }
        }
        // Fill B
        counter = 1;
        int[,] arrayB = new int[n, n];
        for (int i = 0; i < arrayB.GetLength(0); i++)
        {
            for (int j = 0; j < arrayB.GetLength(1); j++)
            {
                if (i % 2 == 0)
                {
                    arrayB[j, i] = counter;
                }
                else
                {
                    arrayB[arrayB.GetLength(1) - j - 1, i] = counter;
                }
                counter++;
            }
        }
        // Fill C
        counter = 1;
        int[,] arrayC = new int[n, n];
        for (int i = 0; i <= n - 1; i++)
        {
            int col = i, row = 0;
            while (row <= i)
            {
                arrayC[arrayC.GetLength(0) - col - 1, row] = counter;
                counter++;
                col--;
                row++;
            }
        }
        for (int i = n - 2; i >= 0; i--)
        {
            int col = 0, row = i;
            while (col <= i)
            {
                arrayC[col, arrayC.GetLength(0) - row - 1] = counter;
                counter++;
                col++;
                row--;
            }
        }
        // Display A
        for (int i = 0; i < arrayA.GetLength(0); i++)
        {
            for (int j = 0; j < arrayA.GetLength(1); j++)
            {
                Console.Write("{0,2}", arrayA[i, j]);
                if (j != arrayA.GetLength(1))
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine(new String('=', n * 2 + (n - 1)));
        // Display B
        for (int i = 0; i < arrayB.GetLength(0); i++)
        {
            for (int j = 0; j < arrayB.GetLength(1); j++)
            {
                Console.Write("{0,2}", arrayB[i, j]);
                if (j != arrayB.GetLength(1))
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine(new String('=', n * 2 + (n - 1)));
        // Display C
        for (int i = 0; i < arrayC.GetLength(0); i++)
        {
            for (int j = 0; j < arrayC.GetLength(1); j++)
            {
                Console.Write("{0,2}", arrayC[i, j]);
                if (j != arrayC.GetLength(1))
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine(new String('=', n * 2 + (n - 1)));
    }
}