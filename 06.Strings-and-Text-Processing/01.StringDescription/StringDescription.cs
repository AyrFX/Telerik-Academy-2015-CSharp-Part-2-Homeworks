/*
 * Problem 1. Strings in C#.
 * 
 * Describe the strings in C#.
 * What is typical for the string data type?
 * Describe the most important methods of the String class.
 */

using System;

class StringDescription
{
    static void Main()
    {
        string text = "A string is an object of type String whose value is text. Internally,\n";
        text += "the text is stored as a sequential, read-only collection of Char objects.\n";
        text += "There is no null-terminating character at the end of a C# string; therefore\n";
        text += "a C# string can contain any number of embedded null characters ('\0'). The\n";
        text += "Length property of a string represents the number of Char objects it contains,\n";
        text += "not the number of Unicode characters. To access the individual Unicode code\n";
        text += "points in a string, the StringInfo object can be used.";
        text += "A string is an array of Unicode characters. We can use the array access\n";
        text += "notation to get a specific character from the string. The number inside the\n";
        text += "square brackets is the index into the array of characters. The index is counted\n";
        text += "from zero. It means that the first character has index 0.";
        text += "Important C# string methods are string.Compare(), that compares String objects;\n";
        text += "string.Equals(), that determines whether two specified String objects have the\n";
        text += "same value; string.IndexOf() that finds a character or substring within given\n";
        text += "string; string.Substring() - extracts substring from the String object;\n";
        text += "string.Split() that splits string object by given separator.";
        Console.WriteLine(text);
    }
}