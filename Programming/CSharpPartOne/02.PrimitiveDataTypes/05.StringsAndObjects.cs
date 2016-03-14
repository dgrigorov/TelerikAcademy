using System;

class StringsAndObjects
{
    static void Main()
    {
        string greeting = "Hello";
        string word = "World";
        object varConcat1 = greeting + " " + word;
        string varConcat2 = (string)varConcat1;
        Console.WriteLine("{0}! (data type is: {1})", varConcat1, varConcat1.GetType());
        Console.WriteLine("{0}! (data type is: {1})", varConcat2, varConcat2.GetType());
    }
}