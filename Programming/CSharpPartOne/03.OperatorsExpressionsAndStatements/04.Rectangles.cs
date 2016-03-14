using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter rectangle’s width and height:");
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double perimeter = (2 * width) + (2 * height);
        Console.WriteLine("Perimeter is:{0}", perimeter);
        Console.WriteLine("Area is {0}", width * height);
    }
}