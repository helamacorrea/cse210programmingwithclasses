using System;

class Program
{
    static void Main(string[] args)
    {
        //magic number 
        
        //decide random number for magic number 1 - 100
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int signal = 0;
        //loop
        while (signal == 0)
        {
            //ask the user to guess the magic number loop
            Console.WriteLine("Guess the magic number (1 - 100): ");
            string guessInput = Console.ReadLine();
            int guessNumber = int.Parse(guessInput);
            //check if the guess is higher, lower or equal the MN
            if (guessNumber == magicNumber)
            {   
                Console.WriteLine("You guessed it!");
                signal = 1;
            }
            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Try again");
            }
        }   














    }
}