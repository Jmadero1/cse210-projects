public class MathAssignment : Assignment
{
    private string _title;

    public MathAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetHomeworkList()
    {
        return $"Section 7.3 Problems 8-19";
    }
}
