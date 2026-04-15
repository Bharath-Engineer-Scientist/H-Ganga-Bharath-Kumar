List<int> scores = new List<int>();
scores.Add(4);
scores.Add(6);
scores.Add(0);
scores.Add(2);
scores.Add(1);
Console.WriteLine("Scores:");
foreach (int s in scores)
{
    Console.WriteLine(s);
}
Console.WriteLine("Total balls: " + scores.Count);
int total = 0;
foreach (int s in scores)
{
    total += s;
}
Console.WriteLine("Total Score: " + total);