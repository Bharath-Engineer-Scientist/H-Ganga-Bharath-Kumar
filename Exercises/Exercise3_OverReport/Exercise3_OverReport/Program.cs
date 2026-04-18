int totalRuns = 0;
int dotBalls = 0;
int boundaries = 0;
bool isOut = false;
int ballsFaced = 0;
Console.WriteLine("--- Over Simulation ---");
for (int ball = 1; ball <= 6; ball++)
{
    Console.Write($"Ball {ball}: Enter digit: ");
    int digit = int.Parse(Console.ReadLine());
    ballsFaced++;
    if (digit == 0)
    {
        isOut = true;
        Console.WriteLine("Out  and innings over.");
        break;
    }
    else if (digit % 2 == 0)
    {
        totalRuns += digit;

        if (digit == 4 || digit == 6)
        {
            boundaries++;
        }
    }
    else
    {
        dotBalls++;
    }
}
Console.WriteLine("\n--- Over Summary ---");
Console.WriteLine($"Runs: {totalRuns}");
Console.WriteLine($"Dots: {dotBalls}");
Console.WriteLine($"Boundaries: {boundaries}");
if (isOut)
{
    Console.WriteLine("Player was out");
}
