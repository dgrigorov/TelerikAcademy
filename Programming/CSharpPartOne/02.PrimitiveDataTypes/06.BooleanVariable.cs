﻿using System;

class BooleanVariable
{
    static void Main()
    {
        Console.WriteLine("Is your gender is female? Enter yes or no!");
        string gender = Console.ReadLine();
        bool isFemale = gender == "yes";
        Console.WriteLine("{0}", isFemale);
    }
}