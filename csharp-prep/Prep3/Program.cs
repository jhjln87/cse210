using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // int magic = int.Parse(Console.ReadLine());
        Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n");
        int play = 1;
        do {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1,100);
            int myNum, i = 1;
            Console.Write("\n\nI am thinking of a random number between 1 and 100. ");
            do {
                Console.Write("What is your guess? ");
                myNum = int.Parse(Console.ReadLine());
                i++;
                switch (myNum) {
                    case int n when n > number:
                        Console.WriteLine("Lower");
                        break;
                    case int n when n < number:
                        Console.WriteLine("Higher");
                        break;
                    default:
                        Console.WriteLine($"You guessed it! It took you {i} tries");
                        break;
                }
            } while (myNum != number);
            Console.Write("Would you like to play again? ");
            string ans = Console.ReadLine().ToLower();
            if (!(ans == "yes" || ans == "ye" || ans == "y")) {
                play = 0;
            }
        } while (play == 1);
    }
}