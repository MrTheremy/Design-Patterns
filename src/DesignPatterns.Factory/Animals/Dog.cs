namespace DesignPatterns.Factory.Animals
{
    public class Dog : IAnimal
    {
        public void Speak()
        {
            {
                Console.WriteLine("Woof!");
            }
        }
    }
}