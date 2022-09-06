
using InterfacesTutorial;

Console.WriteLine("Interfaces");

Boxer joe = new();
joe.Color = "blue";
Parrot poly = new();
Frog bart = new();
ISpeakable joe2 = new Boxer();

List<ISpeakable> pets = new() { joe, poly, bart};

foreach(ISpeakable pet in pets)
{
    pet.Scream();
}

