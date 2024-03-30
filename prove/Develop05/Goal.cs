using System;

namespace EternalQuest.Goals
{
    public abstract class Goal
    {
        protected string _shortName;
        protected string _description;
        protected int _points;

        // Constructor
        public Goal(string shortName, string description, int points)
        {
            _shortName = shortName;
            _description = description;
            _points = points;
        }

        public abstract void RecordEvent();
        public abstract bool IsComplete();
        public abstract string GetDetailsString();
        public abstract string GetStringRepresentation();
    }
}
