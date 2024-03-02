using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a series of numbers. Enter 0 to stop.");

        int input;
        do
        {
            Console.Write("Enter a number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }

        } while (input != 0);

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers entered.");
        }
        else
        {
            // Compute sum
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"Sum: {sum}");

            // Compute average
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"Average: {average}");

            // Find maximum number
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"Maximum number: {max}");
        }
    }
}
