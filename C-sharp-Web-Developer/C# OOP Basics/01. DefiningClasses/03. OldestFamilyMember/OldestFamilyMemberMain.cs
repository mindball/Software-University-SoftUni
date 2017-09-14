﻿using System;
using System.Reflection;

public class OldestFamilyMemberMain
{
    public static void Main()
    {
        MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
        MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
        if (oldestMemberMethod == null || addMemberMethod == null)
        {
            throw new Exception();
        }

        int numberOfPeople = int.Parse(Console.ReadLine());
        var family = new Family();

        for (int i = 0; i < numberOfPeople; i++)
        {
            var input = Console.ReadLine().Split();
            string name = input[0];
            int age = int.Parse(input[1]);

            var person = new Person()
            {
                Age = age,
                Name = name
            };

            family.AddMember(person);
        }

        Console.WriteLine($"{family.GetOldestMember().Name} {family.GetOldestMember().Age}");
    }
}