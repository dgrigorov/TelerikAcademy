using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter weight of a man:");
        double weightMan = double.Parse(Console.ReadLine());
        double weightManOnMoon = (17 * weightMan) / 100;
        Console.WriteLine("Weight of a man on the moon is:{0}", weightManOnMoon);
    }
}