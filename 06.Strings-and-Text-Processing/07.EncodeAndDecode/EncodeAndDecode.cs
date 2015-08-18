/*
 * Problem 7. Encode/decode
 * 
 * Write a program that encodes and decodes a string using given encryption key (cipher).
 * The key consists of a sequence of characters.
 * The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first
 * of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
 */

using System;
using System.Text;

class EncodeAndDecode
{
    static void Main()
    {
        Console.Write("Please enter string: ");
        string text = Console.ReadLine();
        Console.Write("Please enter key: ");
        string key = Console.ReadLine();
        StringBuilder encString = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            encString.Append((char)(text[i] ^ key[i % key.Length]));
        }
        Console.WriteLine("Encrypted string: " + encString.ToString());
        StringBuilder decString = new StringBuilder();
        for (int i = 0; i < encString.Length; i++)
        {
            decString.Append((char)(encString[i] ^ key[i % key.Length]));
        }
        Console.WriteLine("Decrypted string: " + decString.ToString());
    }
}