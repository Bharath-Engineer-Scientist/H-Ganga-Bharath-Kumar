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
        public Innings(string playerName) => PlayerName = playerName;
        private string FormatBallRow(int ballNum, string runText, string resultText)
        {
            string col1 = $"Ball {ballNum}".PadRight(8);
            string col2 = $"{runText} runs".PadLeft(10);
            string col3 = resultText.PadLeft(12);
            return $" {col1} | {col2} | {col3}";
        }
        public void Scorecard()
        {
            string separator = new string('=', 40);
            Console.WriteLine($"\n{separator}");
            Console.WriteLine("BOOK IPL SCORECARD".PadLeft(28));
            Console.WriteLine(separator);
            for (int i = 0; i < Balls.Count; i++)
            {
                Ball b = Balls[i];
                string runDisplay = b.Result == BallResult.Out ? "0" : b.Runs.ToString();
                string resultDisplay = b.Result == BallResult.Out ? "OUT" : (b.Runs >= 4 ? "BOUNDARY!" : "---");

                Console.WriteLine(FormatBallRow(i + 1, runDisplay, resultDisplay));
            }
            Console.WriteLine(separator);
            Console.WriteLine($" Player  : {PlayerName}");
            Console.WriteLine($" Score   : {TotalScore}");
            Console.WriteLine($" Balls   : {BallsPlayed}");
            Console.WriteLine($" Result  : {(IsOut ? "OUT" : "NOT OUT")}");
            Console.WriteLine(separator + "\n");
        }
    }
}