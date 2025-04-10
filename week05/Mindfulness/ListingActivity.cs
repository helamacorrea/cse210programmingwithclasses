public class ListingActivity : Activity 
{
    private List<string> _randomPrompts; 

    private List<string> _userResponses;

    private int _count;
    public ListingActivity(int duration) : base(duration)
    {
        SetActivityName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        _randomPrompts = new List<string> {"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
    }

    public void NumberOfItems()
    {

    }

    public void RunActivity()
    {

    }
    public void GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_randomPrompts.Count);
        Console.WriteLine(_randomPrompts[index]);
    }

    public List<string> GetListFromUser()
    {
        return _userResponses;
    }

    public void AddToUserList(string response)
    {
        _userResponses.Add(response);
    }



}   