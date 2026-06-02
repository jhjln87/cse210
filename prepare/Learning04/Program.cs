using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        MathAssign foo = new MathAssign("alex", "diffeq", "3.4", "2-68");
        Console.WriteLine($"{foo.GetHomeworkList()}\n");
        WriteAssign bar = new WriteAssign("jessie", "advanced writing", "basic rhetoric");
        Console.WriteLine($"{bar.GetWritingInfo()}\n");
    }
}