using System;
namespace Exercise1_OOPRefactor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- WELCOME TO BOOK IPL SESSION ---");
            Console.Write("Enter Player Name: ");
            string name = Console.ReadLine();
            int sessionInnings = 0;
            int sessionRuns = 0;
            int bestScore = -1;
            int bestInningsNum = 0;
            bool keepPlaying = true;
            while (keepPlaying)
            {
                sessionInnings++;
                Console.WriteLine($"\n--- INNINGS #{sessionInnings} STARTING ---");
                Innings game = new Innings(name);
                game.Play();
                game.Scorecard();
                sessionRuns += game.TotalScore;
                if (game.TotalScore > bestScore)
                {
                    if (bestScore != -1) Console.WriteLine("!!! NEW PERSONAL BEST !!!");
                    bestScore = game.TotalScore;
                    bestInningsNum = sessionInnings;
                }
                Console.Write("Play again? (y/n): ");
                string input = Console.ReadLine().ToLower();
                if (input != "y") keepPlaying = false;
            }
            Console.WriteLine("\n==============================");
            Console.WriteLine("       SESSION SUMMARY        ");
            Console.WriteLine("==============================");
            Console.WriteLine($"Total Innings : {sessionInnings}");
            Console.WriteLine($"Total Runs    : {sessionRuns}");
            Console.WriteLine($"Average Score : {Math.Round((double)sessionRuns / sessionInnings, 1)}");
            Console.WriteLine($"Best Score    : {bestScore} (Innings #{bestInningsNum})");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Thanks for playing! Press any key to exit.");
            Console.ReadKey();
        }
    }
}