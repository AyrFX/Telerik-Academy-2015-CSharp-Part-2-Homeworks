/*
 * Problem 3. Read file contents
 * Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on
 * the console.
 * Find in MSDN how to use System.IO.File.ReadAllText(…).
 * Be sure to catch all possible exceptions and print user-friendly error messages.
 */

using System;
using System.IO;

class FileContentsDemo
{
    static void Main()
    {
        Console.Write("Please enter full file path: ");
        string filePath = Console.ReadLine();
        string fileContent = "";
        try
        {
            fileContent = File.ReadAllText(filePath);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file can't be found!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("There is restriction to access the file!");
        }
        catch (IOException)
        {
            Console.WriteLine("The file can't be accessed!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The entered file path is empty!");
        }
        Console.WriteLine("The content of the file is: ");
        Console.WriteLine(fileContent);
    }
}