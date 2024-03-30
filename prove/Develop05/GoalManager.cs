using System;
using System.Collections.Generic;
using System.IO;
using EternalQuest.Goals;

namespace EternalQuest.Player
{
    public class GoalManager
    {
        private List<Goal> _goals;
        private int _score;

        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
        }

        public void LoadGoals(string filePath)
        {
            
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"El archivo {filePath} no existe.");
                return;
            }

            
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length >= 3)
                {
                    string shortName = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);
                    _goals.Add(new SimpleGoal(shortName, description, points));
                }
            }
        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"Score: {_score}");
        }

        public void ListGoalDetails()
        {
            Console.WriteLine("Lista de Metas:");
            foreach (Goal goal in _goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }

        public void CreateGoal()
        {
            
        }

        public void RecordEvent()
        {
            
        }

        public void SaveGoals(string filePath)
        {
            
        }

        
    }
 }