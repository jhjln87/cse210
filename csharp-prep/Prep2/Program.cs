using System;

class Program
{
    static void Main(string[] args)
    {
        // switch (grade)
        // {
        //     case >= 90:
        //         break;
        //     case >= 80:
        //         break;
        //     case >= 70:
        //         break;
        //     case >= 60:
        //         break;
        //     default:
        //         break;
        // }
        // if statement-ception :(
        
        Console.Write("What is your grade percentage-wise?");
        int grade = int.Parse(Console.ReadLine());
        Console.Write("Your letter grade is a");
        string letter;
        if (grade >= 90) {
            letter = "n A";
        }
        else if (grade >= 80) {
            letter = " B";
        }
        else if (grade >= 70) {
            letter = " C";
        }
        else if (grade >= 60) {
            letter = " D";
        }
        else {
            letter = "n F";
        }
        string modify = "";
        if (grade >= 60 && grade < 97) {
            if (grade % 10 >= 7) {
                modify = "+";
            }
            if (grade % 10 < 3) {
                modify = "-";
            }
        }
        Console.Write($"{letter}{modify}");
        if (grade >= 70) {
            Console.Write(". You passed this course, congratulations!");
        }
        else {
            Console.Write(". You were close, but did not pass. Better luck next time!");
        }
    }
}