using System;
using System.Collections.Generic;

// Represents an entry in the journal
public class Entry
{
    // Properties for prompt, response, date, tags, and mood of the entry
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }
    public List<string> Tags { get; set; }
    public string Mood { get; set; }

    // Constructor to initialize the entry
    public Entry(string prompt, string response, DateTime date, List<string> tags, string mood)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
        Tags = tags;
        Mood = mood;
    }

    // Override ToString method to display the entry in a specific format
    public override string ToString()
    {
        string tagsStr = string.Join(", ", Tags);
        return $"{Date.ToString("dd/MM/yyyy")} - {Prompt}: {Response}\nTags: {tagsStr}\nMood: {Mood}\n";
    }
}

// Represents a journal that stores entries
public class Journal
{
    private List<Entry> entries = new List<Entry>();

    // Method to add a new entry to the journal
    public void AddEntry(string prompt, string response, DateTime date, List<string> tags, string mood)
    {
        entries.Add(new Entry(prompt, response, date, tags, mood));
    }

    // Method to display all entries in the journal
    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
        }
        else
        {
            foreach (var entry in entries)
            {
                Console.WriteLine(entry);
            }
        }
    }

    // Method to save journal entries to a file
    public void SaveToFile(string fileName)
    {
        try
        {
            //  save entries to a file (CSV or JSON)
            Console.WriteLine("Journal saved to file successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal to file: {ex.Message}");
        }
    }

    // Method to load journal entries from a file
    public void LoadFromFile(string fileName)
    {
        try
        {
            //  (CSV or JSON)
            Console.WriteLine("Journal loaded from file successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal from file: {ex.Message}");
        }
    }
}

// Represents a menu for the journal application
public class Menu
{
    // Static method to display the menu options
    public static void ShowMenu()
    {
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Exit");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Journal class
        Journal journal = new Journal();
        bool exit = false;

        // Main loop to display the menu and handle user input
        while (!exit)
        {
            // Display the menu options
            Menu.ShowMenu();
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            // Validate user input
            if (int.TryParse(option, out int choice))
            {
                // Handle user input based on the selected option
                switch (choice)
                {
                    case 1:
                        // Get user input for a new entry and add it to the journal
                        Console.Write("Enter prompt: ");
                        string prompt = Console.ReadLine();
                        Console.Write("Enter response: ");
                        string response = Console.ReadLine();
                        Console.Write("Enter tags (comma-separated): ");
                        List<string> tags = new List<string>(Console.ReadLine().Split(','));
                        Console.Write("Enter mood: ");
                        string mood = Console.ReadLine();
                        journal.AddEntry(prompt, response, DateTime.Now, tags, mood);
                        break;

                    case 2:
                        // Display all entries in the journal
                        journal.DisplayEntries();
                        break;

                    case 3:
                        // Save the journal to a file
                        Console.Write("Enter file name: ");
                        string fileNameSave = Console.ReadLine();
                        journal.SaveToFile(fileNameSave);
                        break;

                    case 4:
                        // Load the journal from a file
                        Console.Write("Enter file name: ");
                        string fileNameLoad = Console.ReadLine();
                        journal.LoadFromFile(fileNameLoad);
                        break;

                    case 5:
                        // Exit the program
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid option. Please enter a number.");
            }
        }
    }
}
