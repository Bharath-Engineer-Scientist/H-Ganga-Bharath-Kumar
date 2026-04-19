using System;
using System.Collections.Generic;
using System.Linq;
namespace Exercise1_OOPRefactor
{
    public class Innings
    {
        public string PlayerName { get; }
        public List<Ball> Balls { get; } = new List<Ball>();
        public int TotalScore { get; private set; }
        public bool IsOut { get; private set; }
        public int BallsPlayed => Balls.Count;
        public double StrikeRate => BallsPlayed == 0 ? 0 : Math.Round((TotalScore / (double)BallsPlayed) * 100, 1);
        public int Boundaries => Balls.Count(b => b.Runs == 4 || b.Runs == 6);
        public Innings(string playerName) => PlayerName = playerName;
        public void Play()
        {
            while (BallsPlayed < 6 && !IsOut)
            {
                Console.WriteLine("\nPress any key to flip");
                Console.ReadKey(true);
                int digit = ScoreEngine.FlipPage();
                Ball ball = new Ball(digit);
                Balls.Add(ball);
                string commentary = CommentaryEngine.GetCommentary(ball.Result, ball.Runs);
                Console.WriteLine($">>> {commentary}");
                if (ball.Result == BallResult.Out)
                    IsOut = true;
                else
                    TotalScore += ball.Runs;
                Console.WriteLine($"Ball {BallsPlayed}: {ball} (Total: {TotalScore})");
            }
        }
        public void Scorecard()
        {
            Console.WriteLine($" SCORECARD: {PlayerName.ToUpper()}");
            for (int i = 0; i < Balls.Count; i++)
            {
                Console.WriteLine($"Ball {i + 1}".PadRight(8) + $" | {Balls[i]}".PadLeft(10));
            }
            Console.WriteLine($"Total Score: {TotalScore}");
            Console.WriteLine($"Boundaries : {Boundaries}");
            Console.WriteLine($"Strike Rate: {StrikeRate}");
            Console.WriteLine($"Status     : {(IsOut ? "Out" : "Not Out")}");
        }
    }
}