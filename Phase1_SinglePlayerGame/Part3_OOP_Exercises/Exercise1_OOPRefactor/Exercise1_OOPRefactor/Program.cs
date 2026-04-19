using System;
namespace Exercise1_OOPRefactor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- WELCOME TO BOOK IPL (OOP VERSION) ---");
            Console.Write("Enter Player Name: ");
            string name = Console.ReadLine();
            Innings game = new Innings(name);
            game.Play();
            game.Scorecard();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}