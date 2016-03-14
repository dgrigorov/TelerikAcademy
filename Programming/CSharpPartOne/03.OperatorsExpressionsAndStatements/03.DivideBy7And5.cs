using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter integer number:");
        int numInt = int.Parse(Console.ReadLine());
        bool checkNum7 = (numInt % 7) == 0;
        bool checkNum5 = (numInt % 5) == 0;
        if (numInt == 0)
        {
            checkNum7 = false;
        }
        Console.WriteLine("Divided by 7 and 5? {0}", checkNum7 && checkNum5);
    }
}