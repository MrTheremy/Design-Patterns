namespace DesignPatterns.Singletons
{
    /// <summary>
    /// Class singleton, a singleton should always have only one instance.
    /// We use a sealed class for a singleton to ensure no inheritance.
    /// </summary>
    public sealed class Singleton
    {
        /// <summary>
        /// Having a private constructor avoids new() being called
        /// </summary>
        private Singleton()
        { }

        /// <summary>
        /// In the static _instance the one instance gets stored
        /// </summary>
        private static Singleton _instance;

        /// <summary>
        /// Creates a new instance when none is available. Returns the instance stored in the static _instance field when already created.
        /// Can also be put in a property with only a Getter.
        /// </summary>
        /// <returns>returns the one instance</returns>
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }

        /// <summary>
        /// Some bussiness logic that can be added to the singleton
        /// </summary>
        public void SomeBusinessLogic()
        {
            Console.WriteLine("Bussiness logic of the singleton");
        }
    }
}