using System;

class AfterTenYears
{
    static void Main()
    {
        Console.Write("Enter your birth date: ");
        DateTime BirthDay = DateTime.Parse(Console.ReadLine());
        DateTime now = DateTime.Now;
        int age = (int)((now - BirthDay).TotalDays / 365.242199);
        Console.WriteLine("You are {0} year(s) old", age);
        Console.WriteLine("After ten years you will be at the age of {0}", (age + 10));
    }
}