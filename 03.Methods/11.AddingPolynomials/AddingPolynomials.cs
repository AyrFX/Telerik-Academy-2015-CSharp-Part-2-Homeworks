/*
 * Problem 11. Adding polynomials
 * Write a method that adds two polynomials.
 * Represent them as arrays of their coefficients.
 * 
 * Example:
 * x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}
 */

using System;

class AddingPolynomials
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

    static void Main()
    {
        int[] firstPoly = { 2, 4, -15, 6 };
        int[] secondPoly = { -3, 7, 9, 4 };
        int[] sum = new int[Math.Max(firstPoly.Length, secondPoly.Length)];
        string sumString = "";
        sum = PolyAdd(firstPoly, secondPoly);
        for (int i = 0; i < sum.Length; i++)
        {
            if (sum[i] > 0)
            {
                sumString = " + " + String.Format("{0}x^{1}", sum[i], i) + sumString;
            }
            else if (sum[i] < 0)
            {
                sumString = " - " + String.Format("{0}x^{1}", Math.Abs(sum[i]), i) + sumString;
            }
        }
        sumString = sumString.Replace("x^0", "");
        sumString = sumString.Replace("x^1", "x");
        Console.WriteLine("The sum of polynomials is: " + sumString);
    }
}