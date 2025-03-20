using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double number))
        {
            Console.WriteLine($"You entered a number: {number}");
        }
        else
        {
            Console.WriteLine("Error: The value entered is not a number.");
        }
    }
}
