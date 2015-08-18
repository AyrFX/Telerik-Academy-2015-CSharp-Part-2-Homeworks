/*
 * Problem 22. Words count
 * 
 * Write a program that reads a string from the console and lists all different words in the string along with information how many
 * times each word is found.
 */

using System;

class WordsCount
{
    static void Main()
    {
        Console.Write("Please enter text: ");
        string text = Console.ReadLine();
        string[] words = text.Split(new[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
        int counter = 0;
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == "")
            {
                continue;
            }
            counter = 1;
            for (int j = i + 1; j < words.Length; j++)
            {
                if (words[i] == words[j])
                {
                    counter++;
                    words[j] = "";
                }
            }
            if (counter != 1)
            {
                Console.WriteLine("The word \"{0}\" is found {1} times.", words[i], counter);
            }
            else
            {
                Console.WriteLine("The word \"{0}\" is found {1} time.", words[i], counter);
            }
        }
    }
}