/*void AddRuns()
{
    int runs = 4;
}
AddRuns();
Console.WriteLine(runs);*/ // ERROR

int GetRuns()
{
    int runs = 5;
    return runs;
}
int total = 0;
total += GetRuns();  //5
total += GetRuns(); //5+5=10
total += GetRuns();//10+5=15 result is 15
Console.WriteLine("Total Runs: " + total);

