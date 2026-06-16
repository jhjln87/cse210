using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _iterateThru = new List<Shape>()
        {
            new Circle("Pink", 5.0), // pink circle with 5 unit radius
            new Rectangle("Blue", 4.0, 6.0), // blue rectangle with 4x6 unit lengths
            new Square("Light green", 4.0) // lightgreen square with 4 unit sides
        };
        foreach (Shape item in _iterateThru)
        {
            Console.WriteLine($"{item.GetColor()} {item.GetType().Name} is {item.GetArea()} units squared.");
        }
    }
}