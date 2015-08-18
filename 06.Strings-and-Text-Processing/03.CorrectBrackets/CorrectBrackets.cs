/*
 * Problem 3. Correct brackets
 * 
 * Write a program to check if in a given expression the brackets are put correctly.
 * Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
 */

using System;

class CorrectBrackets
{
    static void Main()
    {
        Console.Write("Please enter expression: ");
        string expression = Console.ReadLine();
        sbyte brackets = 0;
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                brackets++;
            }
            else if (expression[i] == ')')
            {
                brackets--;
            }
            if (brackets < 0)
            {
                Console.WriteLine("The brackets ARE NOT put correctly!!!");
                return;
            }
        }
        Console.WriteLine("The brackets ARE put correctly!!!");
    }
}