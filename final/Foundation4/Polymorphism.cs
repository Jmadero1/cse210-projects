using System;
using System.Collections.Generic;

public abstract class Activity
{
    public DateTime Date { get; set; }
    public int DurationInMinutes { get; set; }

    public Activity(DateTime date, int durationInMinutes)
    {
        Date = date;
        DurationInMinutes = durationInMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date.ToShortDateString()} {GetType().Name} ({DurationInMinutes} min) - Distance: {GetDistance()}, Speed: {GetSpeed()}, Pace: {GetPace()}";
    }
}

public class Running : Activity
{
    public double DistanceInMiles { get; set; }

    public Running(DateTime date, int durationInMinutes, double distanceInMiles)
        : base(date, durationInMinutes)
    {
        DistanceInMiles = distanceInMiles;
    }

    public override double GetDistance()
    {
        return DistanceInMiles;
    }

    public override double GetSpeed()
    {
        return DistanceInMiles / (DurationInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return DurationInMinutes / DistanceInMiles;
    }
}

public class StationaryBicycle : Activity
{
    public double SpeedInMph { get; set; }

    public StationaryBicycle(DateTime date, int durationInMinutes, double speedInMph)
        : base(date, durationInMinutes)
    {
        SpeedInMph = speedInMph;
    }

    public override double GetSpeed()
    {
        return SpeedInMph;
    }

    public override double GetDistance()
    {
        // For stationary bicycle, distance is not applicable
        return 0;
    }

    public override double GetPace()
    {
        // For stationary bicycle, pace is not applicable
        return 0;
    }
}

public class Swimming : Activity
{
    public int Laps { get; set; }
    private const double MetersPerLap = 50.0;
    private const double MetersInMile = 1609.34;

    public Swimming(DateTime date, int durationInMinutes, int laps)
        : base(date, durationInMinutes)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * MetersPerLap / MetersInMile;
    }

    public override double GetSpeed()
    {
        return (Laps * MetersPerLap) / (DurationInMinutes / 60.0) * 0.621371; // Convert meters per minute to miles per hour
    }

    public override double GetPace()
    {
        return DurationInMinutes / (Laps * MetersPerLap / MetersInMile);
    }
}