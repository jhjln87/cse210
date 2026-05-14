public class Entry(string date, string prompt, string answer)
{
    public string _date = date;
    public string _prompt = prompt;
    public string _answer = answer;
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt {_prompt}\n{_answer}\n");
    }
}