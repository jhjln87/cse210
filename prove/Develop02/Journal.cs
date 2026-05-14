using System.IO
public class Journal()
{
    public List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        foreach (Entry i in _entries) {
            i.Display();
        }
    }
    public void Save(string filename)
    {
        using (StreamWriter sw = new StreamWriter(filename))
        foreach (Entry i in _entries)
        {
            sw.WriteLine($"{i._date}|{i._prompt}|{i._answer}");
        }
    }
    public void Read(string filename)
    {
        if (!File.Exists(filename)) return;
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string i in lines)
        {
            string[] parts = i.Split('|');
            if (parts.Length == 3)
            {
                _entries.Add(new Entry(parts[0], parts[1], parts[2]));
            }
        }
    }
}