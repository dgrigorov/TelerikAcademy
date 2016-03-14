using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8; 
        char copyright = '\u00A9';
        int n = 7;

        for (int i = 1; i <= n; i += 2)
        {
            for (int k = (n - i) / 2; k >= 0; k--)
                Console.Write(" ");
            for (int j = 1; j <= i; j++)
                Console.Write(copyright);
            Console.WriteLine();
        }
    }
}
