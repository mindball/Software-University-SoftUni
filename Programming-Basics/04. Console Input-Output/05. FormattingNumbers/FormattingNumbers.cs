﻿using System;

class FormattingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        string line = "|";

        Console.Write("|{0,-10:X}|", a);
        Console.Write(Convert.ToString(a, 2).PadLeft(10, '0'));
        Console.Write(line);
        Console.Write("{0, 10:0.##}", b);
        //Console.Write("{0,10:0.##}", b);
        Console.Write(line);
        Console.Write("{0, -10:F3}", c);
        //Console.Write("{0,-10:0.###}", c);
        Console.WriteLine(line);
    }
}