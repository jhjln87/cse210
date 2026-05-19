public class Fraction()
{
    private int _neumerator;
    private int _denominator;
    public void Set()
    {
        _neumerator = 1;
        _denominator = 1;
    }
    public void Set(int WholeNumber)
    {
        _neumerator = WholeNumber;
        _denominator = 1;
    }
    public void Set(int Top, int Bottom)
    {
        _neumerator = Top;
        _denominator = Bottom;
    }

    public void SetTop(int Top)
    {
        _neumerator = Top;
    }
    public int GetTop()
    {
        return _neumerator;
    }
    public void SetBottom(int Bottom)
    {
        _denominator = Bottom;
    }
    public int GetBottom()
    {
        return _denominator;
    }
    public string GetFractionString()
    {
        return _neumerator.ToString() + "/" + _denominator.ToString();
    }
    public float GetDecimalValue()
    {
        return (float)_neumerator / _denominator;
    }
}