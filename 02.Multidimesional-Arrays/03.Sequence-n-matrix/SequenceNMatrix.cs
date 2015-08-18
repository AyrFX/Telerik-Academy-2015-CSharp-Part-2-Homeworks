/*
 * Problem 3. Sequence n matrix
 * We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on
 * the same line, column or diagonal.
 * Write a program that finds the longest sequence of equal strings in the matrix.
 * 
 * Example:
 * matrix 	                result 		matrix 	    result
 * ha 	fifi 	ho 	hi                  s 	qq 	s
 * fo 	ha 	    hi 	xx      ha, ha, ha  pp 	pp 	s   s, s, s
 * xxx 	ho 	    ha 	xx                  pp 	qq 	s
 */

using System;

class SequenceNMatrix
{
    static void Main()
    {
        string[,] matrix =
		{
			{"ha", "fifi", "ho", "hi"},
			{"fo", "ha", "hi", "xx"},
			{"xxx", "ho", "ha", "xx"}
		};
        /*string[,] matrix =
		{
			{"s", "qq", "s"},
			{"pp", "pp", "s"},
			{"pp", "qq", "s"}
		};*/
        int seqLength = 1, bestSeqLength = int.MinValue;
        string text = "";
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j] == matrix[i, j + 1])
                {
                    seqLength++;
                }
                else
                {
                    seqLength = 1;
                }
                if (seqLength > bestSeqLength)
                {
                    bestSeqLength = seqLength;
                    text = matrix[i, j];
                }
            }
            seqLength = 1;
        }
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                if (matrix[i, j] == matrix[i + 1, j])
                {
                    seqLength++;
                }
                else
                {
                    seqLength = 1;
                }
                if (seqLength > bestSeqLength)
                {
                    bestSeqLength = seqLength;
                    text = matrix[i, j];
                }
            }
            seqLength = 1;
        }
        int diagonals = Math.Abs(matrix.GetLength(0) - matrix.GetLength(1)) + 1;
        if (matrix.GetLength(0) <= matrix.GetLength(1))
        {
            for (int k = 0; k < diagonals; k++)
            {
                for (int i = 0, j = k; j < k + diagonals; i++, j++)
                {
                    if (matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        seqLength++;
                    }
                    else
                    {
                        seqLength = 1;
                    }
                    if (seqLength > bestSeqLength)
                    {
                        bestSeqLength = seqLength;
                        text = matrix[i, j];
                    }
                }
                seqLength = 1;
            }
            for (int k = matrix.GetLength(1) - 1; k >= diagonals; k--)
            {
                for (int i = 0, j = k; j > k - diagonals; i++, j--)
                {
                    if (matrix[i, j] == matrix[i + 1, j - 1])
                    {
                        seqLength++;
                    }
                    else
                    {
                        seqLength = 1;
                    }
                    if (seqLength > bestSeqLength)
                    {
                        bestSeqLength = seqLength;
                        text = matrix[i, j];
                    }
                }
                seqLength = 1;
            }
        }
        else
        {
            for (int k = 0; k < diagonals; k++)
            {
                for (int i = k, j = 0; i < k + diagonals; i++, j++)
                {
                    if (matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        seqLength++;
                    }
                    else
                    {
                        seqLength = 1;
                    }
                    if (seqLength > bestSeqLength)
                    {
                        bestSeqLength = seqLength;
                        text = matrix[i, j];
                    }
                }
                seqLength = 1;
            }
            for (int k = matrix.GetLength(0) - 1; k >= diagonals; k--)
            {
                for (int i = k, j = 0; i > k - diagonals; i--, j++)
                {
                    if (matrix[i, j] == matrix[i - 1, j + 1])
                    {
                        seqLength++;
                    }
                    else
                    {
                        seqLength = 1;
                    }
                    if (seqLength > bestSeqLength)
                    {
                        bestSeqLength = seqLength;
                        text = matrix[i, j];
                    }
                }
                seqLength = 1;
            }
        }
        Console.Write("The longest sequence of equal strings in the matrix is: ");
        for (int i = 0; i < bestSeqLength; i++)
        {
            Console.Write(text);
            if (i != bestSeqLength - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}