using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        // Fraction init = new Fraction();
        // init.Set();
        // Console.WriteLine(init.GetFractionString());
        // Console.WriteLine(init.GetDecimalValue());
        // init.Set(5);
        // Console.WriteLine(init.GetFractionString());
        // Console.WriteLine(init.GetDecimalValue());
        // init.Set(3, 4);
        // Console.WriteLine(init.GetFractionString());
        // Console.WriteLine(init.GetDecimalValue());
        // init.Set(1, 3);
        // Console.WriteLine(init.GetFractionString());
        // Console.WriteLine(init.GetDecimalValue());
        Fraction frac = new Fraction();
        Random randint = new Random();
        for (int i=0; i<20; i++)
        {
            frac.SetTop(randint.Next(1, 11));
            frac.SetBottom(randint.Next(1, 11));
            Console.WriteLine($"Fraction {i+1}: string: {frac.GetFractionString()} Number: {frac.GetDecimalValue()}");
        }
    }
}