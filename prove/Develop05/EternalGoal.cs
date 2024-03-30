using System;

namespace EternalQuest.Goals
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
        {
        }

        public override void RecordEvent()
        {
            // No implementation needed for eternal goals
        }

        public override bool IsComplete()
        {
            return false;
        }

        public override string GetDetailsString()
        {
            return $"{_shortName}: {_description} [Eternal]";
        }

        public override string GetStringRepresentation()
        {
            return $"{_shortName},{_description},{_points},0";
        }
    }
}
