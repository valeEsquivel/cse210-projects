using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number = -1;
        float sum = 0;
        float average = 0;
        int largest = 0;
        int smallestPositive = 100;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0) {
                numbers.Add(number);
            }
        }

        foreach (int num in numbers) {
            sum += num;

            if (num > largest) {
                largest = num;
            }

            if (num > 0 && num < smallestPositive) {
                smallestPositive = num;
            }
        }

        average = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        numbers.Sort();

        Console.WriteLine("The sorted list is: ");
        foreach (int num in numbers) {
            Console.WriteLine($"{num} ");
        }
    }
}