using System;
using System.Collections.Generic;
using System.Linq;

class PrintLongSequence
{
    static void Main()
    {
        IEnumerable<int> numbers = Enumerable.Range(2, 1000);
        foreach (int num in numbers)
        {
            Console.WriteLine(num % 2 == 1 ? num * -1 : num);
        }
    }
}
