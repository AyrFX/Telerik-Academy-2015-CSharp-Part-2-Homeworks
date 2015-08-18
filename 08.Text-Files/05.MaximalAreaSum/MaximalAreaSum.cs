/*
 * Problem 5. Maximal area sum
 * Write a program that reads a text file containing a square matrix of numbers.
 * Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
 * The first line in the input file contains the size of matrix N.
 * Each of the next N lines contain N numbers separated by space.
 * The output should be a single number in a separate text file.
 * 
 * Example:
 * input 	output
 * 4
 * 2 3 3 4
 * 0 2 3 4  17
 * 3 7 1 2
 * 4 3 3 2
 */

using System;
using System.IO;

class MaximalAreaSum
{
    static void Main()
    {
        int[,] matrix = FillMatrix();
        WriteMaximalSum(matrix);
    }

    static int[,] FillMatrix()
    {
        StreamReader reader = new StreamReader(@"..\..\input.txt");
        using (reader)
        {
            int size = int.Parse(reader.ReadLine());
            int[,] matrix = new int[size, size];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] numbers = reader.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < numbers.Length; j++)
                {
                    matrix[i, j] = int.Parse(numbers[j]);
                }
            }
            return matrix;
        }
    }

    static void WriteMaximalSum(int[,] matrix)
    {
        int maxSum = int.MinValue;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row,col] + matrix[row+1,col] + matrix[row,col+1] + matrix[row+1,col+1] > maxSum)
                {
                    maxSum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];
                }
            }
        }
        StreamWriter writer = new StreamWriter(@"..\..\output.txt");
        using (writer)
        {
            writer.WriteLine(maxSum);
        }
    }
}