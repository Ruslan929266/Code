Console.WriteLine("What is your sex? (m/f): ");
bool isMale = Console.ReadLine() == "m";
Console.WriteLine("What is your weight? ");
int weight = Convert.ToInt32(Console.ReadLine());
if (isMale)
{
    if (weight < 55)
        Console.WriteLine("Fliegengewichtig");
    else if (weight < 66)
        Console.WriteLine("Leichtgewichtig");
    else if (weight < 84)
        Console.WriteLine("Mittelgewichtig");
    else if (weight < 85)
        Console.WriteLine("Schwergewichtig");
}
else
{
    if (weight < 48)
        Console.WriteLine("Fliegengewichtig");
    else if (weight < 55)
        Console.WriteLine("Leichtgewichtig");
    else if (weight < 63)
        Console.WriteLine("Mittelgewichtig");
    else if (weight < 64)
        Console.WriteLine("Schwergewichtig");
}
Console.WriteLine("Press any key to exit.");
Console.ReadKey();