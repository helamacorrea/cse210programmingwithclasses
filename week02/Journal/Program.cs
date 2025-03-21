

//The feature I decided to add was the 6th option of the menu "Random Remmembrance"! It`s very cool to use!


using System;
using System.ComponentModel;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello World! This is the Journal Project.");

        //show random prompt, and save with date
        List<string> prompts = new List<string>();
        prompts.Add("Where were you 1 hour ago?");
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");
        Random rnd = new Random();
        Pages entrys = new Pages();
        //List<Entries> entriesList = new List<Entries>();
        
        //Display journal(journal box) (iterate all entries) (before they are saved to a file)

        //save journal to a file (ask the user for a filename)(it should replace)

        //Load the journal from a file (replace entries box)

        //Provide a menu (write, display, Load, Save, Quit. What would you like to do?)
        string userInput = "";
        while (userInput == "" || userInput != "5") 
        {
            Console.WriteLine("1.Write \n2.Display \n3.Load \n4.Save \n5.Quit \n6.Random Remembrance\nWhat would you like to do?");
            userInput = Console.ReadLine();
        
            if (userInput == "1")
            {
                int index = rnd.Next(prompts.Count);
                Console.WriteLine(prompts[index]);
                string userInput02 = Console.ReadLine();
                Entries entry = new Entries
                {
                    _date = DateTime.Now.ToString("yyyy-MM-dd"), // Assign current date
                    _question = prompts[index],
                    _answer = userInput02
                };
                
                entrys.entriesList.Add(entry); // Store in list
                Console.WriteLine("Successfully Recorded in Entries");
                userInput = "";
            } 
            else if (userInput == "2") 
            { //display
                foreach (var entry in entrys.entriesList)
                {
                    Console.WriteLine(entry.FullEntry());
                }

                userInput = "";

            } 
            else if (userInput == "3") 
            { //Load
                Console.WriteLine("What file do you want to Load your journal from?");
                string userInput03 = Console.ReadLine();
                entrys._loadFile = userInput03;
                entrys.LoadFileToEntries();
                userInput = "";

            } 
            else if (userInput == "4") 
            { //Save
                Console.WriteLine("What file do you want to save your journal at?");
                string userInput04 = Console.ReadLine();
                entrys._saveFile = userInput04;
                entrys.SaveEntriesToFile();
                Console.WriteLine("Saved");
                userInput = ""; //Quit
            } 
            else if (userInput == "5") 
            {
                Console.WriteLine("bye");
            } 
            else if (userInput == "6") 
            {
                int index = rnd.Next(entrys.entriesList.Count);
                Console.WriteLine(entrys.entriesList[index].FullEntry());
                userInput = "";
            }
            else 
            {
                Console.WriteLine("Enter a valid answer.");
                userInput = Console.ReadLine();
            }

        }   
        //Propts randomly



    }
}