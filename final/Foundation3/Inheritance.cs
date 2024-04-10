using System;
using System.Collections.Generic;

public class Address
{
    public string Street { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string Country { get; private set; }

    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    public override string ToString()
    {
        return $"{Street}, {City}, {State}, {Country}";
    }
}

public abstract class Event
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public DateTime Date { get; private set; }
    public TimeSpan Time { get; private set; }
    public Address Venue { get; private set; }

    public Event(string title, string description, DateTime date, TimeSpan time, Address venue)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Venue = venue;
    }

    public virtual string GetStandardDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time.ToString(@"hh\:mm")}\nVenue: {Venue}";
    }

    public abstract string GetFullDetails();

    public abstract string GetShortDescription();
}

public class Lecture : Event
{
    public string Speaker { get; private set; }
    public int Capacity { get; private set; }

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address venue, string speaker, int capacity)
        : base(title, description, date, time, venue)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }

    public override string GetShortDescription()
    {
        return $"Type: Lecture\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
    }
}

public class Reception : Event
{
    public string RSVP { get; private set; }

    public Reception(string title, string description, DateTime date, TimeSpan time, Address venue, string rsvp)
        : base(title, description, date, time, venue)
    {
        RSVP = rsvp;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Reception\nRSVP: {RSVP}";
    }

    public override string GetShortDescription()
    {
        return $"Type: Reception\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
    }
}

public class OutdoorGathering : Event
{
    public string WeatherForecast { get; private set; }

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address venue, string weatherForecast)
        : base(title, description, date, time, venue)
    {
        WeatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {WeatherForecast}";
    }

    public override string GetShortDescription()
    {
        return $"Type: Outdoor Gathering\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
    }
}
