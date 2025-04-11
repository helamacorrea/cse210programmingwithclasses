public class Activity 
{
    private string _activityName;
    private string _description;
    private int _duration; //in seconds
    private int _totalDuration;

    public Activity()
    {
        _totalDuration = 0;
    }
    public Activity(int duration)
    {
        _duration = duration;
    }
    public Activity(string activityName, string description, int duration)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }

    

    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }
    public string GetActivityName()
    {
        return _activityName;
    }
    public int GetTotalDuration()
    {
        return _totalDuration;
    }
    public void DisplayStartingMessage()
    {
        //provides the name of the activity, a 
        // description, and asks for and sets the duration
        //  of the activity in seconds. Then, it should 
        // tell the user to prepare to begin and pause for
        //  several seconds.

        Console.WriteLine($"{_activityName}!\n{_description}\n\nHow many seconds do you want the {_activityName} to last? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare Yourself...");
        AnimationSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        //tells the user they have done a good job, and 
        // pause and then tell them the activity they have
        //  completed and the length of time and pauses
        //  for several seconds before finishing.
        Console.WriteLine("Well Done!!");
        AnimationSpinner(3);
        Console.WriteLine($"\n\nYou have completed another {_duration} seconds of the {_activityName}.");
        AnimationSpinner(10);
        _totalDuration += _duration;
    }
    public void AnimationCountdown(int number)
    {
        for (int i = number; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void AnimationSpinner(int seconds)
    {
        List<string> slashesList = new List<string> {"|","/","-","\\"};

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = slashesList[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= slashesList.Count)
            {
                i=0;
            }
        }

    }


}