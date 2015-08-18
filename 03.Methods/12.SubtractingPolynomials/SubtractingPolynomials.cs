/*
 * Problem 12. Subtracting polynomials
 * Extend the previous program to support also subtraction and multiplication of polynomials.
 */

using System;

class SubtractingPolynomials
{
    static int[] PolyAdd(int[] first, int[] second)
    {
        int[] resultArray = new int[Math.Max(first.Length, second.Length)];
        for (int i = 0; i < resultArray.Length; i++)
        {
            if ((i < first.Length) && (i < second.Length))
            {
                resultArray[i] = first[i] + second[i];
            }
            else if (i >= first.Length)
            {
                resultArray[i] = second[i];
            }
            else
            {
                resultArray[i] = first[i];
            }
        }
        return resultArray;
    }

    static int[] PolySubtract(int[] first, int[] second)
    {
        int[] resultArray = new int[Math.Max(first.Length, second.Length)];
        for (int i = 0; i < resultArray.Length; i++)
        {
            if ((i < first.Length) && (i < second.Length))
            {
                resultArray[i] = first[i] + (second[i] * -1);
            }
            else if (i >= first.Length)
            {
                resultArray[i] = second[i];
            }
            else
            {
                resultArray[i] = first[i];
            }
        }
        return resultArray;
    }

    static int[] PolyMultiply(int[] first, int[] second)
    {
        int firstLength = first.Length;
        int secondLength = second.Length;
        int resultLength = firstLength + secondLength - 1;
        int[] resultArray = new int[resultLength];
        for (int i = 0; i < firstLength; i++)
        {
            for (int j = 0; j < secondLength; j++)
            {
                resultArray[i + j] += first[i] * second[j];
            }
        }
        return resultArray;
    }

    static string GetPolyAsString(int[] array)
    {
        string sumString = "";
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == 0)
            {
                continue;
            }
            if (array[i] > 0)
            {
                if (i != array.Length - 1)
                {
                    sumString = " + " + String.Format("{0}x^{1}", array[i], i) + sumString;
                }
                else
                {
                    sumString = String.Format("{0}x^{1}", array[i], i) + sumString;
                }
            }
            else if (array[i] < 0)
            {
                if (i != array.Length - 1)
                {
                    sumString = " - " + String.Format("{0}x^{1}", Math.Abs(array[i]), i) + sumString;
                }
                else
                {
                    sumString = String.Format("{0}x^{1}", array[i], i) + sumString;
                }
            }
        }
        sumString = sumString.Replace("x^0", "");
        sumString = sumString.Replace("x^1", "x");
        sumString = sumString.Replace("1x", "x");
        return sumString;
    }

    static void Main()
    {
        int[] firstPoly = { -4, 5, 3, 1 };
        int[] secondPoly = { 6, -5, -8, 3 };
        int[] sum = new int[Math.Max(firstPoly.Length, secondPoly.Length)];
        sum = PolyAdd(firstPoly, secondPoly);
        string sumString = GetPolyAsString(sum);
        Console.WriteLine("The sum of polynomials is:        " + sumString);
        sum = PolySubtract(firstPoly, secondPoly);
        sumString = GetPolyAsString(sum);
        Console.WriteLine("The differecne of polynomials is: " + sumString);
        sum = PolyMultiply(firstPoly, secondPoly);
        sumString = GetPolyAsString(sum);
        Console.WriteLine("The product of polynomials is:    " + sumString);
    }
}