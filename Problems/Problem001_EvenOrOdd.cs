namespace Day01_HelloWorld.Problems;

public static class Problem001_EvenOrOdd
{
    public static void Solve()
    {
        Console.WriteLine("=== Problem 001: Even or Odd ===");
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int number))
        {
            Console.WriteLine("Please enter a valid integer.");
            return;
        }
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is even.");
        }
        else
        {
            Console.WriteLine($"{number} is odd.");
        }
    }
}


