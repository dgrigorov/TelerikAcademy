using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter integer number:");
        int number = int.Parse(Console.ReadLine());
        bool check = number % 2 != 0;
        Console.WriteLine("Does the number is odd?");
        Console.WriteLine(check);
    }
}