using System;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Run the Contact Management program
            Console.WriteLine("=== Abstraction - Contacts Management ===");
            Abstraction_ContactsManagement.ContactManager contactManager = new Abstraction_ContactsManagement.ContactManager();
            contactManager.AddContact(new Abstraction_ContactsManagement.Contact { Name = "John Doe", PhoneNumber = "123-456-7890", Email = "john@example.com" });
            contactManager.AddContact(new Abstraction_ContactsManagement.Contact { Name = "Jane Smith", PhoneNumber = "987-654-3210", Email = "jane@example.com" });
            contactManager.DisplayContacts();

            // Run the Expense Registration program
            Console.WriteLine("\n=== Encapsulation - Expense Tracker ===");
            Encapsulation_ExpenseTracker.ExpenseTracker expenseTracker = new Encapsulation_ExpenseTracker.ExpenseTracker();
            expenseTracker.AddExpense(new Encapsulation_ExpenseTracker.Expense { Date = DateTime.Today, Description = "Groceries", Amount = 50 });
            expenseTracker.AddExpense(new Encapsulation_ExpenseTracker.Expense { Date = DateTime.Today, Description = "Gas", Amount = 30 });
            expenseTracker.DisplayExpenses();

            
            // Run the Activity Tracking program
            Console.WriteLine("\n=== Polymorphism - Activity Tracker ===");
            Polymorphism_ActivityTracker.Activity running = new Polymorphism_ActivityTracker.Running { Date = DateTime.Today, Distance = 3.5, Duration = 30 };
            running.DisplaySummary();

            Polymorphism_ActivityTracker.Activity swimming = new Polymorphism_ActivityTracker.Swimming { Date = DateTime.Today, Laps = 20, Duration = 45 };
            swimming.DisplaySummary();

            Polymorphism_ActivityTracker.Activity cycling = new Polymorphism_ActivityTracker.Cycling { Date = DateTime.Today, Distance = 10, Duration = 60 };
            cycling.DisplaySummary();
        }
    }
}
