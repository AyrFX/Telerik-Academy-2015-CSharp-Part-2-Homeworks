/*
 * Problem 4. Download file
 * Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
 * Find in Google how to download files in C#.
 * Be sure to catch all exceptions and to free any used resources in the finally block.
 */

using System;
using System.Net;

class FileDownladDemo
{
    static void Main()
    {
        string inputURL = "http://telerikacademy.com/Content/Images/news-img01.png";
        string outputFile = @"d:\NinjaImage.png";
        WebClient Client = new WebClient();
        try
        {
            using (Client)
            {
                Client.DownloadFile(inputURL, outputFile);
            }
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The given URL is null!!!");
        }
        catch (WebException ex)
        {
            Console.WriteLine("The output filename is invalid or data download error!!! " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error!!! " + ex.Message);
        }
        finally
        {
            Client.Dispose();
        }
    }
}