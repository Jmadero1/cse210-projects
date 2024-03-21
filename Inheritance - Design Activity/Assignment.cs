public class Assignment
{
    private string _studentName;
    private string _topic;
    private int _duration;

    public Assignment(string studentName, string topic, int duration)
    {
        _studentName = studentName;
        _topic = topic;
        _duration = duration;
    }

    public virtual void StartActivity()
    {
        // Common starting message
    }

    public virtual void EndActivity()
    {
        // Common ending message
    }
}
