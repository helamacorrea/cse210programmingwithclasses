using System;
using System.ComponentModel;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        //using System.Collections.Generic;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        //ask the user numbers until he says 0 loop
        
        int userNumber = -1;
        List<int> numbers = new List<int>();

        while (userNumber != 0)
        {
            Console.WriteLine("Enter a number: "); 
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            //Add all numbers to the list except 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        //sum all numbers of the list 
        int total = 0;
        int higherNumber = 0;
        foreach (int number in numbers)
        {
            total += number;
            if (higherNumber < number)
            {
                higherNumber = number;
            }
        }
        Console.WriteLine($"The sum is: {total}");

        //return the average of the numbers 
        float rangeList = numbers.Count;

        Console.WriteLine($"The average is: {total / rangeList}");

        //find the higher number in the list range 

        Console.WriteLine($"The largest number is: {higherNumber}");






    }
}