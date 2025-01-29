namespace DesignPatterns.Builders
{
    /// <summary>
    /// Interfacing the builder allows for multiple type of builders for different items with the same kind of structure
    /// </summary>
    public interface IBuilder
    {
        void BuildPartA();

        void BuildPartB();

        void BuildPartC();
    }
}