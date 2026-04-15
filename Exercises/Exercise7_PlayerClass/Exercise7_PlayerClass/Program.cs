class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Player Name: ");
        string name = Console.ReadLine();
        Player p1 = new Player(name);
        Console.Write("Enter runs scored in first ball: ");
        p1.AddRuns(int.Parse(Console.ReadLine()));
        Console.Write("Enter runs scored in second ball: ");
        p1.AddRuns(int.Parse(Console.ReadLine()));
        p1.Describe();
        p1.GetDismissed();
        p1.Describe();
    }
}
class Player
{
    public string Name { get; set; }
    public int Score { get; set; }
    public bool IsOut { get; set; }
    public Player(string playerName)
    {
        Name = playerName;
        Score = 0;
        IsOut = false;
    }
    public void AddRuns(int runs)
    {
        if (!IsOut)
        {
            Score += runs;
        }
    }
    public void GetDismissed()
    {
        IsOut = true;
    }
    public void Describe()
    {
        string status = IsOut ? "Out" : "Not out";
        Console.WriteLine($"{Name} | Score: {Score} | {status}");
    }
}