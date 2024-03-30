using System;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            GoalManager goalManager = new GoalManager();
            ShowMainMenu(goalManager);
        }

        static void ShowMainMenu(GoalManager goalManager)
        {
            Console.WriteLine("Eternal Quest - Main Menu");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Display player's score");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Create new goal");
            Console.WriteLine("4. Record event (accomplished goal)");
            Console.WriteLine("5. Save goals and exit");
            Console.WriteLine();

            try
            {
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        goalManager.DisplayPlayerInfo();
                        break;
                    case 2:
                        goalManager.ListGoalDetails();
                        break;
                    case 3:
                        goalManager.CreateGoal();
                        break;
                    case 4:
                        goalManager.RecordEvent();
                        break;
                    case 5:
                        goalManager.SaveGoals("goals.txt");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            ShowMainMenu(goalManager);
        }
    }

    internal class GoalManager
    {
        internal void CreateGoal()
        {
            throw new NotImplementedException();
        }

        internal void DisplayPlayerInfo()
        {
            throw new NotImplementedException();
        }

        internal void ListGoalDetails()
        {
            throw new NotImplementedException();
        }

        

        internal void RecordEvent()
        {
            throw new NotImplementedException();
        }

        internal void SaveGoals(string v)
        {
            throw new NotImplementedException();
        }
    }
}
