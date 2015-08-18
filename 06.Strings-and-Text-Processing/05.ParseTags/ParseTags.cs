/*
 * Problem 5. Parse tags
 * 
 * You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
 * The tags cannot be nested.
 * Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
 * The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
 */

using System;

class ParseTags
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string startTag = "<upcase>";
        string endTag = "</upcase>";
        int upperStart = 0, upperEnd = 0;
        while (upperStart > -1)
        {
            upperStart = text.IndexOf(startTag, Math.Min(upperStart + 1, text.Length - 1));
            upperEnd = text.IndexOf(endTag, Math.Min(upperStart + 1, text.Length - 1)) - 1;
            if (upperStart > -1)
            {
                text = text.Substring(0, upperStart) + text.Substring(upperStart, upperEnd - upperStart + 1).ToUpper() + text.Substring(upperEnd + 1);
            }
        }
        startTag = startTag.ToUpper();
        do
        {
            upperStart = text.IndexOf(startTag);
            if (upperStart > -1)
            {
                text = text.Replace(startTag, "");
                text = text.Replace(endTag, "");
            }
        }
        while (upperStart > -1);
        Console.WriteLine(text);
    }
}