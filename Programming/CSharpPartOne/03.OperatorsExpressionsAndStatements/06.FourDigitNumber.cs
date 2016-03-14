using System;

class Program
{
    static void Main()
        {
            Console.WriteLine("Enter integer number:");
            int number = int.Parse(Console.ReadLine());
            if ((number / 1000) % 10 == 0)
            {
                Console.WriteLine("The number can not start with '0'");
                return;
            } 
            else
	        {
                Console.WriteLine("The number is: {0}", number);
                int firstDigit = number % 10;
                int secondDigit = (number / 10) % 10;
                int thirdDigit = (number / 100) % 10;
                int fourthDigit = (number / 1000) % 10;
                int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;
                Console.WriteLine("The sum of ({0} + {1} + {2} + {3}) = {4}", firstDigit, secondDigit, thirdDigit, fourthDigit, sum);
                Console.WriteLine("The number in reversed order: {0}{1}{2}{3}", firstDigit, secondDigit, thirdDigit, fourthDigit);
                Console.WriteLine("The last digit in the first position: {0}{1}{2}{3}", firstDigit, fourthDigit, thirdDigit, secondDigit);
                Console.WriteLine("Exchanges the second and the third digits: {0}{1}{2}{3}", fourthDigit, secondDigit, thirdDigit, firstDigit);
	        }
            
        }
}