double CalculateStrikeRate(int runs, int balls)
{
    double rate = (double)runs / balls * 100;
    return rate;
}
Console.Write("Enter runs scored: ");
int runs = int.Parse(Console.ReadLine());
Console.Write("Enter balls faced: ");
int balls = int.Parse(Console.ReadLine());
double strikeRate = CalculateStrikeRate(runs, balls);
Console.WriteLine($"Strike Rate: {strikeRate:F2}");
