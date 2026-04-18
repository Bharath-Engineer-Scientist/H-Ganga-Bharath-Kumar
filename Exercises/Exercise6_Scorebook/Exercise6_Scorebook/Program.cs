Dictionary<string, int> scorebook = new Dictionary<string, int>
{
    { "Rohit", 45 },
    { "Virat", 72 },
    { "Dhoni", 38 },
    { "Bumrah", 5 }
};
Console.WriteLine("This is the Scorebook:");
foreach (var player in scorebook)
{
    Console.WriteLine($"{player.Key} : {player.Value}");
}
int highestScore = 0;
string topPlayer = "";
foreach (var player in scorebook)
{
    if (player.Value > highestScore)
    {
        highestScore = player.Value;
        topPlayer = player.Key;
    }
}
Console.WriteLine($"\nTop Scorer: {topPlayer} with {highestScore} runs");
Console.Write("\nEnter player name to look for runs: ");
string searchName = Console.ReadLine();
if (scorebook.ContainsKey(searchName))
{
    Console.WriteLine($"{searchName} scored {scorebook[searchName]} runs");
}
else
{
    Console.WriteLine("There is no player");
}