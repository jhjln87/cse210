public class MathAssign : Assignment
{
    private float _textbookSection;
    private string _problems;
    public MathAssign() : base()
    {
        _textbookSection = 0;
        _problems = "0-0";
    }
    public void SetSection(string section)
    {
        _textbookSection = float.Parse(section);
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }
    public MathAssign(string student, string topic, string section, string problems) : base(student, topic)
    {
        _textbookSection = float.Parse(section);
        _problems = problems;
    }
    public float GetSection()
    {
        return _textbookSection;
    }
    public string GetProblems()
    {
        return _problems;
    }
    public string GetHomeworkList()
    {
        return $"{GetSummary()}\nSection {_textbookSection} Problems {_problems}";
    }

}