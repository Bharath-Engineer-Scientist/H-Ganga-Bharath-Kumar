class Program
{
    static void Main(string[] args)
    {
        List<Cricketer> team = new List<Cricketer>();
        Console.WriteLine("Enter Batsman Details:");
        Console.Write("Name: ");
        string bName = Console.ReadLine();
        Console.Write("Jersey: ");
        int bJersey = int.Parse(Console.ReadLine());
        Console.Write("Average: ");
        double avg = double.Parse(Console.ReadLine());
        team.Add(new Batsman(bName, bJersey, avg));
        Console.WriteLine("\nEnter Bowler Details:");
        Console.Write("Name: ");
        string boName = Console.ReadLine();
        Console.Write("Jersey: ");
        int boJersey = int.Parse(Console.ReadLine());
        Console.Write("Wickets: ");
        int wickets = int.Parse(Console.ReadLine());
        team.Add(new Bowler(boName, boJersey, wickets));
        Console.WriteLine("\n    Team Introduction    ");
        foreach (Cricketer player in team)
        {
            player.Introduce();
            Console.WriteLine();
        }
    }
}
class Cricketer
{
    public string Name { get; set; }
    public int JerseyNumber { get; set; }
    public Cricketer(string name, int jersey)
    {
        Name = name;
        JerseyNumber = jersey;
    }
    public virtual void Introduce()
    {
        Console.WriteLine($"I am {Name}, jersey #{JerseyNumber}");
    }
}
class Batsman : Cricketer
{
    public double BattingAverage { get; set; }
    public Batsman(string name, int jersey, double avg) : base(name, jersey)
    {
        BattingAverage = avg;
    }
    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine($"Batting average: {BattingAverage}");
    }
}
class Bowler : Cricketer
{
    public int Wickets { get; set; }
    public Bowler(string name, int jersey, int wickets) : base(name, jersey)
    {
        Wickets = wickets;
    }
    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine($"Wickets taken: {Wickets}");
    }
}