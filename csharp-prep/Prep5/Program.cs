using System;
using System.Globalization;

class Program
{
    static void DisplayWelcome() {
        Console.Write("Welcome to the Program!\n");
    }
    static string PromptUserName() {
        Console.Write("Please enter your name: ");
        return Console.ReadLine().ToString();
    }
    static int PromptUserNumber() {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }
    static void PromptUserBirthYear(out int year) {
        Console.Write("Please enter the year you were born: ");
        year = int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int num) {
        return num * num;
    }
    static void DisplayResult(string name, int snum, int year) {
        Console.Write($"{name}, the square of your number is {snum}\n{name}, you will turn (or have turned) {2026-year} this year.");
    }
    static void Main(string[] args) {
        DisplayWelcome();
        string name = PromptUserName();
        int snum = SquareNumber(PromptUserNumber());
        int year;
        PromptUserBirthYear(out year);
        DisplayResult(name, snum, year);
    }
}