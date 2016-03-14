using System;

class EmployeeData
{
    static void Main()
    {
        Console.WriteLine("Enter first name of employee:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter last name of employee :");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter age of employee:");
        string age = Console.ReadLine();
        Console.WriteLine("Enter gender of employee");
        string gender = Console.ReadLine();
        Console.WriteLine("Enter personalIDNumber of employee:");
        long personalIDNumber = long.Parse(Console.ReadLine());
        int uniqueEmployeeNumber = 0;
        do
        {
            Console.WriteLine("Enter unique employee number within scope (27560000…27569999):");
            uniqueEmployeeNumber = int.Parse(Console.ReadLine());
        } while (uniqueEmployeeNumber < 27560000 || uniqueEmployeeNumber > 27569999);
        Console.WriteLine();
        Console.WriteLine("{0} {1} is on {2} years old and is {3}.\nPersonal ID number is: {4} and unique employee number is {5}"
                           , firstName, lastName, age, gender, personalIDNumber, uniqueEmployeeNumber);
        Console.WriteLine();
    }
}