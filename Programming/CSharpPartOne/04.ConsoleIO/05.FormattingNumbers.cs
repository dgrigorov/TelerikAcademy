using System;

class Program
{
    static void Main()
    {
        /*int firstNum = int.Parse(Console.ReadLine());
        float secondNum = float.Parse(Console.ReadLine());
        float thirdNum = float.Parse(Console.ReadLine());

        string hexOutput = String.Format("{0:X}", firstNum);
        string formattedText = "{0, -1} | {1, 10} | {2, 10:0.00} | {3, -1:0.000} |";

        if (firstNum >= 0 && firstNum <= 500)
        {
            Console.WriteLine(formattedText, hexOutput, Convert.ToString(firstNum, 2), secondNum, thirdNum);
        }
        else
        {
            Console.WriteLine("First number should be >= 0 and <= 500!");
            return;
        }*/
        int[] test = { 10212, 10202, 11000, 11000, 11010 };
        ArrayList<Integer> test2 = new ArrayList<Integer>();


        for (int i = test.length - 1; i >= 0; i--)
        {
            int temp = test[i];
            while (temp > 0)
            {
                test2.add(0, temp % 10);  //place low order digit in array
                temp = temp / 10;        //remove low order digit from temp;
            }
        }
    }
}