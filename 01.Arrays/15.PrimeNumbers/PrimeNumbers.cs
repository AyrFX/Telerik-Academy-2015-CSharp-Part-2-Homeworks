/*
 * Problem 15. Prime numbers
 * Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
 */

using System;
using System.Collections.Generic;

class PrimeNumbers
{
    static void Main()
    {
        List<int> listOfNumbers = new List<int>();
        for (int i = 0; i < 10000000; i++)
        {
            listOfNumbers.Add(i);
        }
        for (int i = 2; i < listOfNumbers.Count; i++)
        {
            if (listOfNumbers[i] > 0)
            {
                for (int j = 2; j * i < 10000000; j++)
                {
                    listOfNumbers[j * i] = -1;
                }
            }
        }
        listOfNumbers.RemoveAll(x => x.Equals(-1));
        Console.Write("The first 10 000 000 primes are: ");
        for (int i = 0; i < listOfNumbers.Count; i++)
        {
            Console.Write(listOfNumbers[i]);
            if (i != listOfNumbers.Count)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}