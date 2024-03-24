using System;
using System.Threading;

public class BreathingActivity : Assignment
{
    public BreathingActivity(string studentName) : base(studentName, "Breathing")
    {
    }

    public override void StartActivity(int duration)
    {
        base.StartActivity(duration);
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        // Implement Breathing Activity Logic
    }
}
