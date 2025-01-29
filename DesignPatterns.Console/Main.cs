// The client code.

using DesignPatterns;

Title("Singleton");
SingletonService.Execute();

Console.WriteLine("-------------------------------------------------");

Title("Builder");
BuilderService.Execute();

Console.WriteLine("-------------------------------------------------");

Title("Decorator");
DecoratorService.Execute();

Console.WriteLine("-------------------------------------------------");

void Title(string title)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(title);
    Console.ResetColor();
}