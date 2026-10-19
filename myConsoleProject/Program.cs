

Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

Console.WriteLine("Please enter the package weight:");
int weight = int.Parse(Console.ReadLine());

if (weight > 50)
{
    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
}
else
{
    Console.WriteLine("Please enter the package width:");
    int width = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter the package height:");
    int height = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter the package length:");
    int length = int.Parse(Console.ReadLine());

    int totalDimensions = width + height + length;

    if (totalDimensions > 50)
    {
        Console.WriteLine("Package too big to be shipped via Package Express.");
    }
    else
    {
        // Multiply dimensions together, multiply by weight, divide by 100
        decimal quote = (width * height * length * weight) / 100m;

        // Display the quote as a dollar amount
        Console.WriteLine($"Your estimated total for shipping this package is: {quote:C2}");
        Console.WriteLine("Thank you!");
    }
}

Console.ReadKey();
