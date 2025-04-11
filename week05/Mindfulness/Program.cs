using System;

class Program
{
    static void Main(string[] args)
    {
        //Exceeding Requirements
        //for the Exceeding Requirements I made an addicional option to the Menu! Its returns a relatory
        //  of all completed activities of the program, showing the amount of time spent in each activity!
        //  It was very cool to develop using the Activity Parent Class
        int Menu()
        {
        //allow the user to choose an activity
        Console.WriteLine("Menu Options:\n   1. Start breathing activity\n   2. Start reflecting activity\n   3. Start listing activity\n   4. Total results\n   5. Quit\nSelect a choice from the menu: ");
        string choice = Console.ReadLine();
        return int.Parse(choice);
        }
        
        BreathingActivity b1 = new BreathingActivity();
        ReflectionActivity r1 = new ReflectionActivity();
        ListingActivity l1 = new ListingActivity();

        int choice = 0;
        while (choice != 5)
        {
            Console.Clear();
            choice = Menu();
            if (choice == 1)
            {
                b1.RunActivity();
            }
            else if (choice == 2)
            {
                r1.RunActivity();
            }
            else if (choice == 3)
            {  
                l1.RunActivity();
            }
            else if (choice == 4)
            {
                Console.Write("Loading results...");
                b1.AnimationSpinner(5);
                Console.WriteLine($"\n{b1.GetTotalDuration()} seconds completed in {b1.GetActivityName()}.");
                Console.WriteLine($"{r1.GetTotalDuration()} seconds completed in {r1.GetActivityName()}.");
                Console.WriteLine($"{l1.GetTotalDuration()} seconds completed in {l1.GetActivityName()}.");
                Console.WriteLine("\nPress enter to come back to the menu: ");
                Console.ReadLine();
            }
            









        }
    }    
}