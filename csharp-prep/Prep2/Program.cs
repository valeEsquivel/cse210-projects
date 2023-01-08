using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.Write("Write your percentage grade: ");
        
        string gradeFromUser = Console.ReadLine();
        float grade = float.Parse(gradeFromUser);
        string letter = "";
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";

            if (grade % 10 < 3)
            {
                sign = "-";
            }
        }
        else if (grade >= 80)
        {
            letter = "B";

            if (grade % 10 < 3)
            {
                sign = "-";
            } 
            else if (grade % 10 > 7)
            {
                sign = "+";
            } 
            else
            {
                sign = "";
            }
        }
        else if (grade >= 70)
        {
            letter = "C";

            if (grade % 10 < 3)
            {
                sign = "-";
            } 
            else if (grade % 10 > 7)
            {
                sign = "+";
            } 
            else
            {
                sign = "";
            }
        }
        else if (grade >= 60)
        {
            letter = "D";

            if (grade % 10 < 3)
            {
                sign = "-";
            } 
            else if (grade % 10 > 7)
            {
                sign = "+";
            } 
            else
            {
                sign = "";
            }
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"{letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("You passed. Congratulations!");
        }
        else
        {
            Console.WriteLine("You failed! Try hard the next time!");
        }
    }
}