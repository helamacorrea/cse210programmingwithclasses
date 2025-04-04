using System;
using System.Runtime.InteropServices;
using System.Security.Authentication;

class Program
{
    static void Main(string[] args)
    {
        
        //For the exeeding requirements I did a surprize challenge at when the user finishes to erase all 
        // words. The challange is to write the words of the scriptures to the console and they will show up 
        // on the scripture

        Reference r1 = new Reference("John",3,16);
        Scripture s1 = new Scripture(r1, "16.For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.");
        Reference r2 = new Reference("Proverbs", 3, 5, 6);
        Scripture s2 = new Scripture(r2, "5.Trust in the Lord with all your heart and lean not on your own understanding; 6.In all your ways submit to him, and he will make your paths straight.");
        
        Console.Clear();
        Console.WriteLine(s1.GetDisplayText());
        Console.WriteLine("");
        Console.WriteLine(s2.GetDisplayText());
        Console.WriteLine("Press Enter or type 'quit': ");
        string answer = Console.ReadLine();
        while (answer != "quit")
        {
            s1.HideRandomWords();
            s2.HideRandomWords();
            Console.Clear();
            Console.WriteLine(s1.GetDisplayText());
            Console.WriteLine(s2.GetDisplayText());
            if (s1.IsCompletelyHidden() && s2.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden!");
                Console.WriteLine("Do you want to try the hardest challenge?(y/n)");
                string answer1 = Console.ReadLine();
                if (answer1 == "y")
                {
                    Console.WriteLine("Type one word of the Scripture (type 'quit' to give up): ");
                    answer1 = Console.ReadLine();
                    while (answer1 != "quit")
                    {
                        s1.FindWordInScripture(answer1);
                        s2.FindWordInScripture(answer1);
                        Console.Clear();
                        Console.WriteLine(s1.GetDisplayText());
                        Console.WriteLine(s2.GetDisplayText());
                        Console.WriteLine("Type one word of the Scripture (type 'quit' to give up): ");
                        answer1 = Console.ReadLine();
                    }

                }   
                else
                {
                    answer = "quit";
                }
                
            } 
            else 
            {
                Console.WriteLine("Press Enter or type 'quit': ");
                answer = Console.ReadLine();
            }

        }

    
    }
}