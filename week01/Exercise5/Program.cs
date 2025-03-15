using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //DisplayWlcome 
        static void Main()
        {
            DisplayWelcome();
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();
            int squareNumber = SquareNumber(userNumber);
            DisplayResult(userName, squareNumber);
        }
    
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        //PromptUserName
        static string PromptUserName()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        //PromptUserNumber
        static int PromptUserNumber()
        {
            Console.WriteLine("Enter your favorite number: ");
            string number1 = Console.ReadLine();
            int number = int.Parse(number1);
            return number;
        }

        //SquareNumber
        static int SquareNumber(int number)
        {
            int squaredNumber = number * number;
            return squaredNumber;
        }

        //DisplayResult
        static string DisplayResult(string name, int number)
        {   
            Console.WriteLine($"{name}, the square of your number is {number}");
            return $"{name}, the square of your number is {number}";
        }

        Main();



    }
}