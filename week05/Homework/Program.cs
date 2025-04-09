using System;

class Program
{
    static void Main(string[] args)
    {
        
        Assignment a1 = new Assignment("Benjamin","History");
        string print = a1.GetSummary();
        Console.WriteLine(print);

        MathAssignment m1 = new MathAssignment("Benjamin", "History", "Math 7:3", "Problemns 8-9");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());

        WritingAssignment w1 = new WritingAssignment("Benjamin", "History","Great Nation Issue in the XXI Century");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());
    }
}