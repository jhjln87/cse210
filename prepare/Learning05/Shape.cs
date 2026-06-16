public abstract class Shape
{
    protected string _color;
    public string GetColor()
    {
        return _color;
    }
    protected Shape(string clr)
    {
        _color = clr;
    }
    public abstract double GetArea();
}