/*
 * Problem 2. Reverse string
 * 
 * Write a program that reads a string, reverses it and prints the result at the console.
 * Example:
 * input 	output
 * sample 	elpmas
 */

using System;

class StringReverse
{
    static void Main()
    {
        Console.Write("Please enter sting: ");
        string inputText = Console.ReadLine();
        string reversedText = "";
        for (int i = inputText.Length - 1; i >= 0; i--)
        {
            reversedText += inputText[i];
        }
        Console.WriteLine("The reversed string is " + reversedText);
    }
}