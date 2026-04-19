using System;
namespace Exercise1_OOPRefactor
{
    public enum BallResult { Dot, Runs, Out }
    public static class ScoreEngine
    {
        private static Random _random = new Random();
        public static int FlipPage() => _random.Next(100, 1000) % 10;
        public static (BallResult result, int runs) GetScore(int digit)
        {
            if (digit == 0) return (BallResult.Out, 0);
            if (digit % 2 == 0) return (BallResult.Runs, digit);
            return (BallResult.Dot, 0);
        }
    }
}