using System;

class Program
{
    static void Main(string[] args)
    {
        string guessNumber = "";
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);
        int times = 0;

        do {          
            Console.Write("What is your guess? ");
            guessNumber = Console.ReadLine();
            times++;

            if (magicNumber > int.Parse(guessNumber))
            {
                Console.WriteLine("Higher.");
            }
            else if (magicNumber < int.Parse(guessNumber))
            {
                Console.WriteLine("Lower.");
            } else {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {times} times to guess the number.");
            }
        } while (magicNumber != int.Parse(guessNumber));
    }
}