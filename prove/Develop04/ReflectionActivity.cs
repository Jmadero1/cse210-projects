using System;
using System.Threading;

public class ReflectionActivity : Assignment
{
    public ReflectionActivity(string studentName) : base(studentName, "Reflection")
    {
    }

    public override void StartActivity(int duration)
    {
        base.StartActivity(duration);
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        // Implement Reflection Activity Logic
    }
}
