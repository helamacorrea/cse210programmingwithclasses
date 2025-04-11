public class BreathingActivity : Activity 
{
    public BreathingActivity()
    {
        SetActivityName("Breathing Activity");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");    
    }
    // public BreathingActivity(string name, string description, int duration, List<string> randomPrompts) : base(name, description, duration)
    // {
    // }
    
    public void RunActivity()
    {
        DisplayStartingMessage();
        Breathe();
        DisplayEndingMessage();
    }

    public void Breathe()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            AnimationCountdown(4);
            Console.WriteLine();
            Console.Write("Breathe out...");
            AnimationCountdown(6);
            Console.WriteLine("\n\n");
        }
    }

    
}