namespace Exercise1_OOPRefactor
{
    public class Ball
    {
        public int Digit { get; }
        public BallResult Result { get; }
        public int Runs { get; }
        public Ball(int digit)
        {
            Digit = digit;
            var score = ScoreEngine.GetScore(digit);
            Result = score.result;
            Runs = score.runs;
        }
        public override string ToString()
        {
            if (Result == BallResult.Out) return "Out";
            return Result == BallResult.Dot ? "0" : Runs.ToString();
        }
    }
}