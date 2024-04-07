using System;

namespace Polymorphism_ActivityTracker
{
    public abstract class Activity
    {
        public DateTime Date { get; set; }
        public int Duration { get; set; }

        public abstract void DisplaySummary();
    }

    public class Running : Activity
    {
        public double Distance { get; set; }

        public override void DisplaySummary()
        {
            Console.WriteLine($"Running ({Date}): Distance: {Distance} miles");
        }
    }

    public class Swimming : Activity
    {
        public int Laps { get; set; }

        public override void DisplaySummary()
        {
            Console.WriteLine($"Swimming ({Date}): Laps: {Laps}");
        }
    }

    public class Cycling : Activity
    {
        public double Distance { get; set; }

        public override void DisplaySummary()
        {
            Console.WriteLine($"Cycling ({Date}): Distance: {Distance} miles");
        }
    }
}
