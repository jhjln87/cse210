public class Job {
    public string _jobTitle;
    public string _CompanyName;
    public int _startYear;
    public int _endYear;
    public Job() {
    }
    public void Display() {
        Console.WriteLine($"{_jobTitle} ({_CompanyName}) {_startYear}-{_endYear}");
    }
}