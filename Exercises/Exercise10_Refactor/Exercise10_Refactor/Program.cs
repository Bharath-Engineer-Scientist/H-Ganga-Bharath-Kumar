class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Player Name: ");
        Player player = new Player(Console.ReadLine());
        ScoreEngine engine = new ScoreEngine();
        for (int i = 1; i <= 6; i++)
        {
            if (player.IsOut) break;
            Console.Write($"Ball {i} - Enter page digit (0-9): ");
            int digit = int.Parse(Console.ReadLine());
            int runs = engine.GetScore(digit);
            if (runs == -1)
            {
                player.GetDismissed();
                Console.WriteLine("OUT!");
            }
            else
            {
                player.AddRuns(runs);
                Console.WriteLine($"Added {runs} runs.");
            }
        }
        player.Describe();
    }
}
class Player
{
    public string Name { get; set; }
    public int Score { get; set; }
    public bool IsOut { get; set; }
    public Player(string name)
    {
        Name = name;
        Score = 0;
        IsOut = false;
    }
    public void AddRuns(int runs)
    {
        if (!IsOut) Score += runs;
    }
    public void GetDismissed()
    {
        IsOut = true;
    }
    public void Describe()
    {
        string status = IsOut ? "OUT" : "Not out";
        Console.WriteLine($"\n{Name} | Final Score: {Score} | Status: {status}");
    }
}
class ScoreEngine
{
    public int GetScore(int digit)
    {
        if (digit == 0) return -1;
        if (digit % 2 == 0) return digit;
        return 0;
    }
}