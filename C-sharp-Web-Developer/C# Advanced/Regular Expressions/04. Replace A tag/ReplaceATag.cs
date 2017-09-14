﻿using System;
using System.Text;
using System.Text.RegularExpressions;

public class ReplaceATag
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"<a(href=.*?)>(.*?)<\/a>";

        StringBuilder sb = new StringBuilder();
        while (input != "end")
        {
            sb.Append(input);
            sb.Replace(" ", ""); // removing white spaces
            sb.Replace("\t", ""); // removing white spaces
            input = Console.ReadLine();
        }

        string fromSB = sb.ToString();
        input = Regex.Replace(fromSB, pattern, m => "[URL " + m.Groups[1].Value + "]" + m.Groups[2].Value + "[/URL]");

        Console.WriteLine(input);
    }
}
