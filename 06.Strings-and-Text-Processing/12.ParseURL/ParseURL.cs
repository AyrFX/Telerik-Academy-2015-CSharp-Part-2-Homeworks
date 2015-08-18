/*
 * Problem 12. Parse URL
 * 
 * Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol],
 * [server] and [resource] elements.
 * Example:
 * URL 	                                                    Information
 * http://telerikacademy.com/Courses/Courses/Details/212 	[protocol] = http
 *                                                          [server] = telerikacademy.com
 *                                                          [resource] = /Courses/Courses/Details/212
 */

using System;

class ParseURL
{
    static void Main()
    {
        string url = "http://telerikacademy.com/Courses/Courses/Details/212";
        int charStartIndex = 0;
        charStartIndex = url.IndexOf("://");
        string protocol = url.Substring(0, charStartIndex);
        charStartIndex += "://".Length;
        int charEndIndex = url.IndexOf("/", charStartIndex + "://".Length);
        string server = url.Substring(charStartIndex, charEndIndex - charStartIndex);
        string resource = url.Substring(charEndIndex);
        Console.WriteLine("[protocol] = " + protocol);
        Console.WriteLine("[server] = " + server);
        Console.WriteLine("[resource] = " + resource);
    }
}