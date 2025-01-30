using DesignPatterns.Factory.Animals;

namespace DesignPatterns.Factory
{
    public class AnimalFactory
    {
        public IAnimal CreateAnimal(AnimalTypes animalType)
        {
            switch (animalType)
            {
                case AnimalTypes.Dog:
                    return new Dog();

                case AnimalTypes.Cat:
                    return new Cat();

                default:
                    throw new ArgumentException("Invalid animal type.");
            }
        }
    }
}