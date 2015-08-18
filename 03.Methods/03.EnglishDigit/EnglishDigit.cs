/*
 * Problem 3. English digit
 * Write a method that returns the last digit of given integer as an English word.
 * 
 * Examples:
 * input 	output
 * 512 	    two
 * 1024 	four
 * 12309 	nine
 */

using System;

class EnglishDigit
{
    static string LastDigitWord(int number)
    {
        int digit = number % 10;
        switch (digit)
        {
            case 0:
                return "zero";
            case 1:
                return "one";
            case 2:
                return "two";
            case 3:
                return "three";
            case 4:
                return "four";
            case 5:
                return "five";
            case 6:
                return "six";
            case 7:
                return "seven";
            case 8:
                return "eight";
            case 9:
                return "nine";
            default:
                return "";
        }
    }
    static void Main()
    {
        Console.WriteLine("Please, enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The last digit of given number is " + LastDigitWord(number));
    }
}