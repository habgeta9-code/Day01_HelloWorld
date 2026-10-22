using Day01_HelloWorld.Problems;

Console.WriteLine("===Day01_Hello world===");
Console.WriteLine("1. Even or Odd");

Console.WriteLine("choose the problem: ");
string? choice = Console.ReadLine();

switch (choice)
{
    case "1":
         Problem001_EvenOrOdd.Solve();
         break;
    default:
       Console.WriteLine("invalid selection");
       break;
}


