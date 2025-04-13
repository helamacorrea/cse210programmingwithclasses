//for all menu functionality
using System.Runtime.CompilerServices;
using System.IO;

public class GoalManager 
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public int GetScore()
    {
        return _score;
    }
    public void Start()
    {
        string answer = "0";
        while (answer != "6")
        {
            Console.WriteLine($"You have {_score} points.\n\nMenu Options:\n   1. Create New Goal\n   2. List Goals\n   3. Save Goals\n   4. Load Goals\n   5. Record Event\n   6. Quit\nSelect an option from the menu: ");
            answer = Console.ReadLine();
            if (answer == "1")
            {
                CreateNewGoal(); //done
            }
            else if (answer == "2")
            {
                ListGoalDetails(); //
            }
            else if (answer == "3")
            {
                SaveGoals();
            }
            else if (answer == "4")
            {
                LoadGoals();
            }
            else if (answer == "5")
            {
                RecordEvent();
            }
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are: ");
        int order = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{order++}. {goal.GetDetailsString()}");
        }
    }
    public void CreateNewGoal()
    {
        string answer;
        string goalName;
        string goalDescription;
        int goalPoints;
        Console.WriteLine($"The types of Goals are:\n   1. Simple Goal\n   2. Eternal Goal\n   3. Checklist Goal\nWhat type of goal would you like to create? ");
        answer = Console.ReadLine();
        Console.WriteLine("What is the Goal Name? ");
        goalName = Console.ReadLine();
        Console.WriteLine("Give a Description for the goal: ");
        goalDescription = Console.ReadLine(); 
        Console.WriteLine("How many points will you receive for this goal? ");
        goalPoints = int.Parse(Console.ReadLine()); 
       
        if (answer == "1")
        {
            _goals.Add(new SimpleGoal(goalName,goalDescription, goalPoints));
        }
        else if (answer == "2")
        {
            _goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
        }
        else if (answer == "3")
        {
           Console.WriteLine("How many times do you want to set as the Target of the goal? ");
           int target = int.Parse(Console.ReadLine());
           Console.WriteLine("How many points will you receive as a bonus when you complete the entire goal?");
           int bonus = int.Parse(Console.ReadLine());
           _goals.Add(new CheckListGoal(goalName, goalDescription, goalPoints, target, bonus));
        }

    }
    public void RecordEvent() //sum points here
    {
        Console.WriteLine($"The goals are:");
        int order = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{order++}. {goal.GetName()}");
        }
        Console.WriteLine("What goal did you accomplished?" );
        int choice = int.Parse(Console.ReadLine())-1;
        _goals[choice].RecordEvent();
        _score += _goals[choice].GetPoints();
        Console.WriteLine($"Your accomplishment has been recorded!\nYou won {_goals[choice].GetPoints()} points!");
        if (_goals[choice].IsCheckListFull() > 0)
        {
            _score += _goals[choice].IsCheckListFull();
            Console.WriteLine($"Congratulations!!! You won a bonus of {_goals[choice].IsCheckListFull()} points!!");
        }

        

   }  
    public void SaveGoals()
    {
        Console.WriteLine("Type the file you want to save your goals to" );
        string fileName = Console.ReadLine();
        File.WriteAllText(fileName, String.Empty); 
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            
            outputFile.WriteLine($"Score:{_score}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
            
        }
        Console.WriteLine("You saved your Goals!");
    }
    public void LoadGoals()
    {
        Console.WriteLine("Type the file you want to Load your goals from" );
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName); 

        foreach (string line in lines)
        {

            string[] parts = line.Split(":");
            string part1 = parts[0];
            string part3 = parts[1];
            
            
            if (part1 == "Score")
            {
                _score = int.Parse(part3);
            }
            else 
            {
                string [] part2 = part3.Split("**");
                string goalName = part2[0];
                string goalDescription = part2[1];
                int goalPoints = int.Parse(part2[2]);

                if (part1 == "SimpleGoal")
                {
                    bool completed = bool.Parse(part2[3]); 
                    _goals.Add(new SimpleGoal(goalName,goalDescription, goalPoints, completed));
                }
                else if (part1 == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
                }
                else if (part1 == "CheckListGoal")
                {
                    int bonus = int.Parse(part2[3]);
                    int target = int.Parse(part2[4]);
                    int amount = int.Parse(part2[5]);
                    _goals.Add(new CheckListGoal(goalName, goalDescription, goalPoints, target, bonus, amount));
                }
            }
        }
            
        
    }

}