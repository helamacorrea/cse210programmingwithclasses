using System;

class Program
{
    static void Main(string[] args)
    {
        //for exceeding requirements the program deletes all 
        // content of a file before saving more content to it, this 
        // way the user can keep using the same folders to his goals,
        // it'll even going to be very useful for me!  
        GoalManager menu = new GoalManager();
        menu.Start();
    }
}