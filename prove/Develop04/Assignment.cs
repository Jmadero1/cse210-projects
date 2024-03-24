using System;

public class Assignment
{
    protected string _studentName;
    protected string _activityName;
    protected int _duration;

    public Assignment(string studentName, string activityName)
    {
        _studentName = studentName;
        _activityName = activityName;
    }

    public virtual void StartActivity(int duration)
    {
        _duration = duration;
        Console.WriteLine($"Starting {_activityName} activity for {_studentName}...");
        // Implement common starting message and countdown
    }

    public virtual void EndActivity()
    {
        // Implement common ending message and countdown
        Console.WriteLine($"Congratulations {_studentName}! You've completed the {_activityName} activity.");
    }
}
