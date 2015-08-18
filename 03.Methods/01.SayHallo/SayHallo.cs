/*
 * Problem 1. Say Hello
 * Write a method that asks the user for his name and prints “Hello, <name>”
 * Write a program to test this method.
 * 
 * Example:
 * input 	output
 * Peter 	Hello, Peter!
 */

using System;

class SayHallo
{
    static void Hallo()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hallo, {0}!", name);
    }

    static void Main()
    {
        Hallo();
    }
}