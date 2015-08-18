/*
 * Problem 2. Random numbers
 * Write a program that generates and prints to the console 10 random values in the range [100, 200].
 */

using System;

class RandomNumbers
{
    static void Main()
    {
        Random gen = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(gen.Next(100, 201));  // по условие интервалът е затворен; докато .next работи с отворен отдясно интервал;
        }                                           // за това максималната стойност е 201
    }
}