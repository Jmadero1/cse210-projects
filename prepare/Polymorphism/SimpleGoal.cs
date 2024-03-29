using System;

namespace EternalQuest.Goals
{
    public class SimpleGoal : Goal
    {
        private bool _isComplete;

        // Constructor
        public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
        {
            _isComplete = false;
        }

        
        public override void RecordEvent()
        {
            _isComplete = true;
        }

        
        public override bool IsComplete()
        {
            return _isComplete;
        }

        
        public override string GetDetailsString()
        {
            return $"{_shortName}: {_description} [{(_isComplete ? "Completed" : "Incomplete")}]";
        }

        
        public override string GetStringRepresentation()
        {
            return $"{_shortName},{_description},{_points},{(_isComplete ? 1 : 0)}";
        }
    }
}
