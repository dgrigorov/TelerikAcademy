using System;

class ComparingFloats
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers:");
        double numDouble1 = double.Parse(Console.ReadLine());
        double numDouble2 = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        bool checkNum = Math.Abs(numDouble1 - numDouble2) < eps;
        if (Math.Abs(numDouble1 - numDouble2) < eps)
        {
            Console.WriteLine(checkNum);
            Console.WriteLine("Explanation: The difference {0} < eps ({1})", (numDouble1 - numDouble2), eps);
        }
        else if (Math.Abs(numDouble1 - numDouble2) >= eps)
        {
            Console.WriteLine(checkNum);
            Console.WriteLine("Explanation: The difference {0} >= eps ({1})", (numDouble1 - numDouble2), eps);
        }
        
    }
}
