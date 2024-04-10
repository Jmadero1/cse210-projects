class Program
{
    static void Main()
    {
        List<Event> events = new List<Event>();

        Console.WriteLine("Creating Lecture Event:");
        Lecture lecture = CreateLectureEvent();
        events.Add(lecture);

        Console.WriteLine("\nCreating Reception Event:");
        Reception reception = CreateReceptionEvent();
        events.Add(reception);

        Console.WriteLine("\nCreating Outdoor Gathering Event:");
        OutdoorGathering outdoorGathering = CreateOutdoorGatheringEvent();
        events.Add(outdoorGathering);

        Console.WriteLine("\nMarketing Messages:");
        foreach (var ev in events)
        {
            Console.WriteLine("\nStandard Details:");
            Console.WriteLine(ev.GetStandardDetails());

            Console.WriteLine("\nFull Details:");
            Console.WriteLine(ev.GetFullDetails());

            Console.WriteLine("\nShort Description:");
            Console.WriteLine(ev.GetShortDescription());
        }
    }

    static Lecture CreateLectureEvent()
    {
        Console.Write("Title: ");
        string title = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Date (MM/DD/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.Write("Time (HH:MM): ");
        TimeSpan time = TimeSpan.Parse(Console.ReadLine());

        Console.Write("Venue Street: ");
        string street = Console.ReadLine();

        Console.Write("Venue City: ");
        string city = Console.ReadLine();

        Console.Write("Venue State: ");
        string state = Console.ReadLine();

        Console.Write("Venue Country: ");
        string country = Console.ReadLine();

        Address venue = new Address(street, city, state, country);

        Console.Write("Speaker: ");
        string speaker = Console.ReadLine();

        Console.Write("Capacity: ");
        int capacity = int.Parse(Console.ReadLine());

        return new Lecture(title, description, date, time, venue, speaker, capacity);
    }

    static Reception CreateReceptionEvent()
    {
        Console.Write("Title: ");
        string title = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Date (MM/DD/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.Write("Time (HH:MM): ");
        TimeSpan time = TimeSpan.Parse(Console.ReadLine());

        Console.Write("Venue Street: ");
        string street = Console.ReadLine();

        Console.Write("Venue City: ");
        string city = Console.ReadLine();

        Console.Write("Venue State: ");
        string state = Console.ReadLine();

        Console.Write("Venue Country: ");
        string country = Console.ReadLine();

        Address venue = new Address(street, city, state, country);

        Console.Write("RSVP Email: ");
        string rsvp = Console.ReadLine();

        return new Reception(title, description, date, time, venue, rsvp);
    }

    static OutdoorGathering CreateOutdoorGatheringEvent()
    {
        Console.Write("Title: ");
        string title = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Date (MM/DD/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.Write("Time (HH:MM): ");
        TimeSpan time = TimeSpan.Parse(Console.ReadLine());

        Console.Write("Venue Street: ");
        string street = Console.ReadLine();

        Console.Write("Venue City: ");
        string city = Console.ReadLine();

        Console.Write("Venue State: ");
        string state = Console.ReadLine();

        Console.Write("Venue Country: ");
        string country = Console.ReadLine();

        Address venue = new Address(street, city, state, country);

        Console.Write("Weather Forecast: ");
        string weatherForecast = Console.ReadLine();

        return new OutdoorGathering(title, description, date, time, venue, weatherForecast);
    }
}