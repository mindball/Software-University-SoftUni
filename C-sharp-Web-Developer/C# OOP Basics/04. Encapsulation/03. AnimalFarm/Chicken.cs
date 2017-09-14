﻿using System;

internal class Chicken
{
    private string name;
    private int age;
    private int productPerDay;

    public Chicken(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name
    {
        get { return name; }
        private set
        {
            if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"Name cannot be empty.");
            }
            name = value;
        }
    }

    public int Age
    {
        get { return age; }
        private set
        {
            if (age > 0 & age < 15)
            {
                throw new ArgumentException($"Age should be between 0 and 15.");
            }
            age = value;
        }
    }

    public double GetProductPerDay()
    {
        return this.CalculateProductPerDay();
    }

    public double CalculateProductPerDay()
    {
        switch (this.Age)
        {
            case 0:
            case 1:
            case 2:
            case 3:
                return 1.5;
            case 4:
            case 5:
            case 6:
            case 7:
                return 2;
            case 8:
            case 9:
            case 10:
            case 11:
                return 1;
            default:
                return 0.75;
        }
    }
}