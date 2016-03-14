using System;

class BankAccountData
{
    static void Main()
    {
        Console.WriteLine("Enter first name account:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter middle name account:");
        string middleName = Console.ReadLine();
        Console.WriteLine("Enter last name account:");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter balance account:");
        int balance = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bank name account:");
        string bankName = Console.ReadLine();
        Console.WriteLine("Enter IBAN account:");
        string iBAN = Console.ReadLine();
        Console.WriteLine("Enter number of first credit card account:");
        string firstCreditCard = Console.ReadLine();
        Console.WriteLine("Enter number of second credit card account:");
        string secondCreditCard = Console.ReadLine();
        Console.WriteLine("Enter number of third credit card account:");
        string thirdCreditCard = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("First name:{0}", firstName);
        Console.WriteLine("Middle name:{0}", middleName);
        Console.WriteLine("Last name:{0}", lastName);
        Console.WriteLine("Balance:{0}", balance);
        Console.WriteLine("Bank name:{0}", bankName);
        Console.WriteLine("IBAN: {0}", iBAN);
        Console.WriteLine("First credit card:{0}", firstCreditCard);
        Console.WriteLine("Second credit card:{0}", secondCreditCard);
        Console.WriteLine("Third credit card:{0}", thirdCreditCard);
    }
}