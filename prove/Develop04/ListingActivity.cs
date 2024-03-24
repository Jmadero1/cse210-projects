using System;
using System.Threading;

public class ListingActivity : Assignment
{
    public ListingActivity(string studentName) : base(studentName, "Listing")
    {
    }

    public override void StartActivity(int duration)
    {
        base.StartActivity(duration);
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        // Implement Listing Activity Logic
    }
}
