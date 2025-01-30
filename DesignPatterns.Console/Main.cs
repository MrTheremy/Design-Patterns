using DesignPatterns;

internal class Program
{
    private static void Main(string[] args)
    {
        Title("Singleton");
        SingletonService.Execute();

        Console.WriteLine("-------------------------------------------------");

        Title("Builder");
        BuilderService.Execute();

        Console.WriteLine("-------------------------------------------------");

        Title("Decorator");
        DecoratorService.Execute();

        Console.WriteLine("-------------------------------------------------");

        Title("Factory");
        FactoryService.Execute();

        Console.WriteLine("-------------------------------------------------");

        static void Title(string title)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(title);
            Console.ResetColor();
        }
    }
}