public class ReflectionActivity : Activity 
{
    private List<string> _randomPrompts; 
    private List<string> _randomQuestions;


    public ReflectionActivity()
    {
        SetActivityName("Reflection Activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        _randomPrompts = new List<string> {"Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
        _randomQuestions = new List<string> {"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?", "How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};
    }

    public void RunActivity()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        Console.Write("Now ponder on each of the following questions as they related to this experience. \nYou may begin in: ");
        AnimationCountdown(8);
        Console.Clear();
        GetRandomQuestion();
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_randomPrompts.Count);
        Console.WriteLine($"Consider the following prompt:\n\n---{_randomPrompts[index]}---\n\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void GetRandomQuestion()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Random rnd = new Random();
            int index = rnd.Next(_randomQuestions.Count);
            Console.Write(_randomQuestions[index]);
            AnimationSpinner(15);
            Console.WriteLine();
        }

    }




}