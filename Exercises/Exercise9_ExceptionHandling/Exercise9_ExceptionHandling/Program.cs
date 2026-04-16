class Program
{
    static void Main(string[] args)
    {
        int validDigit = AskForDigit("Enter the last digit of the book page (0-9): ");
        Console.WriteLine($"Success! You entered a valid digit: {validDigit}");
    }
    static int AskForDigit(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            try
            {
                int digit = int.Parse(input);
                if (digit >= 0 && digit <= 9)
                {
                    return digit;
                }
                else
                {
                    Console.WriteLine("Please enter a digit between 0 and 9.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("That is not a valid digit. Please try again.");
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occurred. Please try again.");
            }
        }
    }
}