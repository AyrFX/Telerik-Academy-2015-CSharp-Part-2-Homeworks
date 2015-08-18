/*
 * Problem 6. Sum integers
 * You are given a sequence of positive integer values written into a string, separated by spaces.
 * Write a function that reads these values from given string and calculates their sum.
 * Example:
 * input 	            output
 * "43 68 9 23 318" 	461
 */

using System;

class SumOfInts
{
    static void Main()
    {
        string intSequence = "43 68 9 23 318";
        Console.WriteLine("The sum of integers is " + calcSum(intSequence));
    }

    static int calcSum(string inputString)
    {
        int sum = 0;
        string[] intArray = inputString.Split(' ');
        for (int i = 0; i < intArray.Length; i++)
        {
            sum += int.Parse(intArray[i]);
        }
        return sum;
    }
}