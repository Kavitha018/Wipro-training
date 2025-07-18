using System;
class Program
{
    static void Main()

    {
        int a;

        int b;

        Console.WriteLine("Enter the first number: ");

        a = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Enter the second number: ");

        b = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Addition: " + (a + b));

        Console.WriteLine("Subtraction: " + (a - b));

        Console.WriteLine("Multiplication: " + (a * b));
        if (b != 0)
        {
            int result = a / b;
            Console.WriteLine("Divisio: " + result);
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        Console.ReadKey();
    }
}