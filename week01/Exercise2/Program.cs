using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        Console.WriteLine("Type your score: ");
        string inputScore = Console.ReadLine();
        int score = int.Parse(inputScore);

        if (score >= 90) 
        {
            letter = "A";
        }
        else if (score >= 80) 
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else if (score < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");






    }
}