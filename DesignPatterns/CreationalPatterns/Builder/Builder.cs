namespace DesignPatterns.CreationalPatterns.Builder
{
    /// <summary>
    /// Builder pattern:
    /// Separate object construction from representation.
    /// </summary>
    public abstract class Builder
    {
        public abstract void BuildPartA();

        public abstract void BuildPartB();

        public abstract Product GetProduct();
    }
}