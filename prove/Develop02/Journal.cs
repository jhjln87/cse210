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
        if (!filename.Contains(".txt"))
        {
            if (filename.Contains("."))
            {
                filename = filename.Replace(".", "");
            }
            filename += ".txt";
        }
        using (StreamWriter sw = new StreamWriter(filename))
        {
            foreach (Entry i in _entries)
            {
                sw.WriteLine($"{i._date}|{i._prompt}|{i._answer}");
            }
        }
    }
    public void Read(string filename)
    {
        if (!filename.Contains(".txt"))
        {
            if (filename.Contains("."))
            {
                filename = filename.Replace(".", "");
            }
            filename += ".txt";
        }
        if (!File.Exists(filename)) return;
        _entries.Clear();
        
        string[] lines = File.ReadAllLines(filename);
        if (lines.Length > 0)
        {

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
}