using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter position: ");
        int p = int.Parse(Console.ReadLine());

        bool isOne = ((n >> p) & 1) == 1;
        Console.WriteLine("bit @ p == 1: {0}", isOne);
    }
}