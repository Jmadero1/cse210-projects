public class ListingActivity : Assignment
{
    public ListingActivity(string studentName, string topic, int duration) : base(studentName, topic, duration)
    {
    }

    public override void StartActivity()
    {
        base.StartActivity();
        // Implement listing activity starting message and countdown
    }

    public override void EndActivity()
    {
        base.EndActivity();
        // Implement listing activity ending message and countdown
    }
}
