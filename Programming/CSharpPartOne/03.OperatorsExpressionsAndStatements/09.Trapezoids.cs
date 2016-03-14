using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter 'a': ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please enter 'b': ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Please enter a height: ");
        int height = int.Parse(Console.ReadLine());
        int area = (a + (b - a) / 2) * height;
        Console.WriteLine("Trapezoid's area is: ");
    }
}