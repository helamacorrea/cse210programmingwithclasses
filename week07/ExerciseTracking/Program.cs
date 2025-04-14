using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activitiesList = new List<Activity>();

        activitiesList.Add(new Running("14 Apr 2025", 30, 4.8));
        activitiesList.Add(new Cycling("14 Apr 2025", 30, 9.7));
        activitiesList.Add(new Swimming("14 Apr 2025", 30, 30));

        foreach (Activity activity in activitiesList)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}