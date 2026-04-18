List<string> squad = new List<string>
{
    "Rohit",
    "Virat",
    "Dhoni",
    "Bumrah",
    "Jadeja"
};
void PrintSquad(List<string> players)
{
    Console.WriteLine("\n This is the Squad List :");

    for (int i = 0; i < players.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {players[i]}");
    }
}
PrintSquad(squad);
Console.Write("\nEnter the player name to add: ");
string newPlayer = Console.ReadLine();
squad.Add(newPlayer);
Console.WriteLine("\nPlayer added successfully");
PrintSquad(squad);
Console.Write("\nEnter the player name to remove: ");
string removePlayer = Console.ReadLine();
if (squad.Contains(removePlayer))
{
    squad.Remove(removePlayer);
    Console.WriteLine("Player removed successfully");
}
else
{
    Console.WriteLine("There is no player");
}
PrintSquad(squad);
