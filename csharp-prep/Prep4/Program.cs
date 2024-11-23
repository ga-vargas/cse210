using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers. Type 0 when finished");

        int input;
        do
        {
            Console.Write("Enter Number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }

        } while (input != 0);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");

        double average = 0;
        if (numbers.Count > 0)
        {
            average = (double)sum / numbers.Count;
        }
        Console.Write($"The average is {average}");

        int max = int.MinValue;
        foreach (int number in numbers)
        {
            if (number > max)
            { max = number; }
        }
        Console.Write($"The largest number is {max}");
    }
}

