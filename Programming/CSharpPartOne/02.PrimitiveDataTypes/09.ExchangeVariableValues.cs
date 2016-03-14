using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before swaping:");
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
        b -= a;
        a += b;
        Console.WriteLine("After swaping:");
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
    }
}