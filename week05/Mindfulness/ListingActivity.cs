public class ListingActivity : Activity 
{
    private List<string> _randomPrompts; 

    private List<string> _userResponses = new List<string>();

    private int _count;
    public ListingActivity()
    {
        SetActivityName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        _randomPrompts = new List<string> {"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
    }
    public void RunActivity()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        AnimationCountdown(6);
        Console.WriteLine();
        _count = GetListFromUser().Count;
        Console.WriteLine($"Yout listed {_count} items!");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_randomPrompts.Count);
        Console.WriteLine($"---{_randomPrompts[index]}---");
    }

    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            string userString = Console.ReadLine();
            _userResponses.Add(userString);
        }
        
        return _userResponses;
    }


}   