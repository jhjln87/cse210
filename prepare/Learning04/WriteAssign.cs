public class WriteAssign : Assignment
{
    private string _title;
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetTitle()
    {
        return _title;
    }
    public WriteAssign() : base()
    {
        _title = "Writing";
    }
    public WriteAssign(string student, string topic, string title) : base(student, topic)
    {
        _title = title;
    }
    public string GetWritingInfo() 
    {
        return $"{GetSummary()}\n{_title} by {GetName()}";
    }
}