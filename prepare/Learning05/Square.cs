public class Square : Shape
{
    private double _sideLength;
    public Square(string color, double side) : base(color)
    {
        _sideLength = side;
    }
    public override double GetArea()
    {
        return Math.Pow(_sideLength, 2);
    }
}