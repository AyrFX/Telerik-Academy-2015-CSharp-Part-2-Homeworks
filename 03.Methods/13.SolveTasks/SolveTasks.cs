/*
 * Problem 13. Solve tasks
 * Write a program that can solve these tasks:
 *  Reverses the digits of a number
 *  Calculates the average of a sequence of integers
 *  Solves a linear equation a * x + b = 0
 * Create appropriate methods.
 * Provide a simple text-based menu for the user to choose which task to solve.
 * Validate the input data:
 *  The decimal number should be non-negative
 *  The sequence should not be empty
 *  a should not be equal to 0
 */

using System;

class SolveTasks
{
    static void Main()
    {
        char choice;
        do
        {
            Console.Clear();
            Console.WriteLine("Please chiose task:\n");
            Console.WriteLine("(1) Reverse the digits of a number");
            Console.WriteLine("(2) Calculate the average of a sequence of integers");
            Console.WriteLine("(3) Solves a linear equation a * x + b = 0");
            Console.WriteLine("(4) Exit\n");
            Console.WriteLine("Press number from 1 to 3");
            choice = Console.ReadKey().KeyChar;
            switch (choice)
            {
                case '1':
                    ReverseNumber();
                    break;
                case '2':
                    FindAverage();
                    break;
                case '3':
                    SolveLinear();
                    break;
                case '4':
                    break;
                default:
                    break;
            }
        }
        while (choice != '4');
    }

    static void ReverseNumber()
    {
        Console.Clear();
        Console.WriteLine("Please enter posotove decimal number: ");
        double decNumber;
        if (!double.TryParse(Console.ReadLine(), out decNumber))
        {
            Console.WriteLine("Wrong decimal!");
            Console.ReadLine();
            return;
        }
        if (decNumber < 0)
        {
            Console.WriteLine("Wrong decimal!");
            Console.ReadLine();
            return;
        }
        else
        {
            string numberAsString = Convert.ToString(decNumber);
            string reversedNumber = "";
            for (int i = 0; i < numberAsString.Length; i++)
            {
                reversedNumber = numberAsString[i] + reversedNumber;
            }
            Console.WriteLine("Reversed number is: " + reversedNumber);
            Console.ReadLine();
        }
    }

    static void FindAverage()
    {
        Console.Clear();
        Console.Write("Please enter the number of integers: ");
        int seqSize = int.Parse(Console.ReadLine());
        if (seqSize <= 0)
        {
            Console.WriteLine("The sequence needs to have at least 1 element!");
            Console.ReadLine();
            return;
        }
        int[] intArray = new int[seqSize];
        int sum = 0;
        for (int i = 0; i < intArray.Length; i++)
        {
            Console.Write("Pleas enter the {0} integer of sequence: ", i + 1);
            intArray[i] = int.Parse(Console.ReadLine());
            sum += intArray[i];
        }
        Console.WriteLine("The average of the sequence is " + (double) sum / seqSize);
        Console.ReadLine();
    }

    static void SolveLinear()
    {
        Console.Clear();
        Console.Write("Please enter a argument of equation a * x + b = 0: ");
        int a = int.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("a can't be 0!");
            Console.ReadLine();
            return;
        }
        Console.Write("Please enter b argument of equation a * x + b = 0: ");
        int b = int.Parse(Console.ReadLine());
        double x = (double)-b / a;
        Console.WriteLine("x = " + x);
        Console.ReadLine();
    }
}