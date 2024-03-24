using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        string studentName = "Jesus Madero";
        
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            int choice = int.Parse(Console.ReadLine());
            Assignment activity;

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity(studentName);
                    break;
                case 2:
                    activity = new ReflectionActivity(studentName);
                    break;
                case 3:
                    activity = new ListingActivity(studentName);
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }

            Console.WriteLine("Enter duration in seconds:");
            int duration = int.Parse(Console.ReadLine());

            activity.StartActivity(duration);
            Thread.Sleep(duration * 1000); // Simulate activity duration
            activity.EndActivity();
        }
    }
}
