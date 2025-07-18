using System;

class Program
{
    static void Main()
    {
        // Ask user to enter the first number
        Console.Write("Enter the first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        // Ask user to enter the second number
        Console.Write("Enter the second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        // Calculate the sum
        int sum = a + b;

        // Display the result
        Console.WriteLine("The sum of {0} and {1} is: {2}", a , b , sum);
    }
}