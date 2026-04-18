// 1. Welcome the player and ask for their name
// 2. Explain the rules of Book IPL
// 3. Play an innings — 6 balls or until OUT
// a. Flip a page (generate a random number)
// b. Get the last digit
// c. Work out what that digit means
// d. Show the result to the player
// 4. Print the final scorecard
// 5. Say goodbye
using System;
using System.Collections.Generic;
namespace BookIPL_Procedural
{
    enum BallResult
    {
        Dot,
        Runs,
        Out
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowWelcome();
            string playerName = AskPlayerName();
            ShowRules();
            var result = PlayInnings(playerName);
            PrintScorecard(playerName, result.totalScore, result.ballsPlayed, result.isOut, result.history);
            ShowGoodbye();
        }

        static void ShowWelcome()
        {
            Console.WriteLine("       WELCOME TO BOOK IPL CRICKET         ");
        }
        static string AskPlayerName()
        {
            Console.Write("Enter batsman name: ");
            return Console.ReadLine();
        }
        static void ShowRules()
        {
            Console.WriteLine("\nGame Rules:");
            Console.WriteLine(" You face 1 over ");
            Console.WriteLine(" Even digits (2, 4, 6, 8) = Runs");
            Console.WriteLine(" Odd digits (1, 3, 5, 7, 9) = Dot Ball");
            Console.WriteLine(" Digit 0 = Out");
            Console.WriteLine("\nPress any key to start the match");
            Console.ReadKey(true);
        }
        static (int totalScore, int ballsPlayed, bool isOut, List<string> history) PlayInnings(string name)
        {
            Random randomEngine = new Random();
            int totalScore = 0;
            int ballsPlayed = 0;
            bool isOut = false;
            List<string> ballResults = new List<string>();
            while (ballsPlayed < 6 && !isOut)
            {
                Console.WriteLine("\nPress any key to flip the page");
                Console.ReadKey(true);
                int pageNumber = randomEngine.Next(100, 1000);
                int lastDigit = pageNumber % 10;
                var (result, runs) = GetScore(lastDigit);
                ballsPlayed++;
                if (result == BallResult.Out)
                {
                    Console.WriteLine($" Ball {ballsPlayed} | Out | Innings over");
                    isOut = true;
                    ballResults.Add("Out");
                }
                else if (result == BallResult.Runs && (runs == 4 || runs == 6))
                {
                    totalScore += runs;
                    ballResults.Add(runs.ToString());
                    Console.WriteLine($" Ball {ballsPlayed} | {runs} runs | Boundary | Total: {totalScore}");
                }
                else if (result == BallResult.Runs)
                {
                    totalScore += runs;
                    ballResults.Add(runs.ToString());
                    Console.WriteLine($" Ball {ballsPlayed} | {runs} runs | Total: {totalScore}");
                }
                else
                {
                    ballResults.Add("0");
                    Console.WriteLine($" Ball {ballsPlayed} | Dot ball | Total: {totalScore}");
                }
            }
            return (totalScore, ballsPlayed, isOut, ballResults);
        }
        static void PrintScorecard(string playerName, int totalScore, int ballsPlayed, bool isOut, List<string> ballResults)
        {
            Console.WriteLine("            INNINGS SCORECARD             ");
            Console.WriteLine($"Player: {playerName}");
            for (int i = 0; i < ballResults.Count; i++)
            {
                string label = $"Ball {i + 1}".PadRight(10);
                string result = ballResults[i].PadLeft(6);
                Console.WriteLine($"{label} | {result}");
            }
            Console.WriteLine($"Total Score : {totalScore}");
            Console.WriteLine($"Balls Faced : {ballsPlayed}");
            Console.WriteLine($"Result      : {(isOut ? "Out" : "Not out")}");
        }
        static void ShowGoodbye()
        {
            Console.WriteLine("Thank you for playing Book IPL");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
        static (BallResult, int) GetScore(int digit)
        {
            if (digit == 0) return (BallResult.Out, 0);
            if (digit % 2 == 0) return (BallResult.Runs, digit);
            return (BallResult.Dot, 0);
        }
    }
}