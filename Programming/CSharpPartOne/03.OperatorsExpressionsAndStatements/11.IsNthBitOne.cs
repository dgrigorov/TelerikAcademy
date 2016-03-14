using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter number: ");
        int n = int.Parse(Console.ReadLine());
        int p = 3;

        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;
        Console.WriteLine("bit @ p: {0}", bit);
    }
}