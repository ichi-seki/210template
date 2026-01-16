using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int enter = 0;

        do
        {
            Console.Write("Enter a list of numbers, type 0 to end.");
            enter = int.Parse(Console.ReadLine());

            if (enter != 0)
            {
                numbers.Add(enter);
            }
        } while (enter != 0);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is {sum}");

        float avg = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {avg}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is {max}");
    }
}