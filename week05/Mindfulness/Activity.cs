public class Activity 
{
    private string _activityName;
    private string _description;
    private int _duration; //in seconds


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
    public void Menu()
    {
        //allow the user to choose an activity

    }
    public void DisplayStartingMessage()
    {
        //provides the name of the activity, a 
        // description, and asks for and sets the duration
        //  of the activity in seconds. Then, it should 
        // tell the user to prepare to begin and pause for
        //  several seconds.
    }

    public void DisplayEndingMessage()
    {
        //tells the user they have done a good job, and 
        // pause and then tell them the activity they have
        //  completed and the length of time and pauses
        //  for several seconds before finishing.
    }
    public void PauseSpinner(int seconds)
    {
        //Whenever the application pauses it should show 
        // some kind of animation to the user, such as a 
        // spinner, a countdown timer, or periods being 
        // displayed to the screen.
        Thread.Sleep(5000);


    }
    public void PauseCountDown(int seconds)
    {

    }
    public void AnimationCountdown()
    {
    
    }

    public void AnimationSpinner()
    {

    }

    public void AnimationPeriods()
    {

    }


}