using System;
using Mirror_Number;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int secondNumber = int.Parse(Console.ReadLine());

        Operation operation = new Operation();

        Console.WriteLine();

        Console.WriteLine("Prime numbers between {0} and {1}:", firstNumber, secondNumber);
        for (int i = firstNumber; i <= secondNumber; i++)
        {
            if (operation.IsPrime(i))
                Console.Write(i + "-");
        }

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Palindrome numbers between {0} and {1}:", firstNumber, secondNumber);
        for (int i = firstNumber; i <= secondNumber; i++)
        {
            if (operation.IsPalindrome(i))
                Console.Write(i + "-");
        }

        Console.ReadLine();
    }
}