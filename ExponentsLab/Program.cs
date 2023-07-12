Console.WriteLine("Learn your squares and cubes with me!");
while (true)
{
    Console.WriteLine("\nEnter an integer:");
    int number = GetIntegerInput();

    Console.WriteLine("\nNumber\tsquare\tcube");
    
    for (int i = 1; i <= number; i++)
    {
        int square = CalculateSquare(i);
        int cube = CalculateCube(i);

        Console.WriteLine($"{i}\t{square}\t{cube}");
    }
    Console.WriteLine("\n Do you want to generate another table? (y/n)");
    string choice = Console.ReadLine();

    if (choice.ToLower() != "y")
        break;

    Console.Clear();
}
Console.WriteLine("\nExiting the program, Press any key to continue....");
Console.ReadKey();

static int CalculateSquare(int number)
{
    return number * number;
}

static int CalculateCube(int number)
{
    return number * number * number;
}
static int GetIntegerInput()
{
    int results;
    while (!int.TryParse(Console.ReadLine(), out results))
    {
        Console.WriteLine("Invalid input. Please enter a valid integer:");
    }
    return results;
}