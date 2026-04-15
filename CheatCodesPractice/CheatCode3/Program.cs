Random random = new Random();
int FlipPage()
{
    return random.Next(100, 999) % 10;
}
int ball1 = FlipPage();
int ball2 = FlipPage();
int ball3 = FlipPage();
Console.WriteLine("Ball 1: " + ball1);
Console.WriteLine("Ball 2: " + ball2);
Console.WriteLine("Ball 3: " + ball3);
