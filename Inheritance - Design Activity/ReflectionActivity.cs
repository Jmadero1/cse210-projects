public class ReflectionActivity : Assignment
{
    public ReflectionActivity(string studentName, string topic, int duration) : base(studentName, topic, duration)
    {
    }

    public override void StartActivity()
    {
        base.StartActivity();
        // Implement reflection activity starting message and countdown
    }

    public override void EndActivity()
    {
        base.EndActivity();
        // Implement reflection activity ending message and countdown
    }
}
