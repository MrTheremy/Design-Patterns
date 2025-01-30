using DesignPatterns.Factory;

namespace DesignPatterns
{
    internal class FactoryService
    {
        public static void Execute()
        {
            {
                AnimalFactory factory = new AnimalFactory();

                IAnimal dog = factory.CreateAnimal(AnimalTypes.Dog);
                dog.Speak(); // Output: Woof!

                IAnimal cat = factory.CreateAnimal(AnimalTypes.Cat);
                cat.Speak();
            }
        }
    }
}