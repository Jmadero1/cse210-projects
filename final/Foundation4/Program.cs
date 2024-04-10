class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        Console.WriteLine("Enter details for Running:");
        Running running = EnterRunningDetails();
        activities.Add(running);

        Console.WriteLine("Enter details for Stationary Bicycle:");
        StationaryBicycle bicycle = EnterStationaryBicycleDetails();
        activities.Add(bicycle);

        Console.WriteLine("Enter details for Swimming:");
        Swimming swimming = EnterSwimmingDetails();
        activities.Add(swimming);

        Console.WriteLine("\nActivity Summary:");
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }

    static Running EnterRunningDetails()
    {
        Console.Write("Date (MM/DD/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.Write("Duration (minutes): ");
        int duration = int.Parse(Console.ReadLine());

        Console.Write("Distance (miles): ");
        double distance = double.Parse(Console.ReadLine());

        return new Running(date, duration, distance);
    }

    static StationaryBicycle EnterStationaryBicycleDetails()
    {
        Console.Write("Date (MM/DD/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.Write("Duration (minutes): ");
        int duration = int.Parse(Console.ReadLine());

        Console.Write("Speed (mph): ");
        double speed = double.Parse(Console.ReadLine());

        return new StationaryBicycle(date, duration, speed);
    }

    static Swimming EnterSwimmingDetails()
    {
        Console.Write("Date (MM/DD/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.Write("Duration (minutes): ");
        int duration = int.Parse(Console.ReadLine());

        Console.Write("Number of laps: ");
        int laps = int.Parse(Console.ReadLine());

        return new Swimming(date, duration, laps);
    }
}