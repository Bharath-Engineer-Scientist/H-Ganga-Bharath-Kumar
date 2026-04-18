Console.WriteLine("--- Umpire Signal System ---");
Console.Write("Enter the last digit of page number: ");
int digit = int.Parse(Console.ReadLine());
switch (digit)
{
    case 0:
        Console.WriteLine("The player is out");
        break;
    case 2:
        Console.WriteLine("2 runs scored");
        break;
    case 4:
        Console.WriteLine("4 Boundary");
        break;
    case 6:
        Console.WriteLine("6 Maximum");
        break;
    case 8:
        Console.WriteLine("8 runs scored");
        break;
    case 1:
    case 3:
    case 5:
    case 7:
    case 9:
        Console.WriteLine($"{digit} — Dot ball — no runs");
        break;
    default:
        Console.WriteLine("Invalid input. Please enter a digit between 0 and 9.");
        break;
}
