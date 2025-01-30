namespace DesignPatterns.Factory.Animals
{
    public class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Meow!");
        }
    }
}