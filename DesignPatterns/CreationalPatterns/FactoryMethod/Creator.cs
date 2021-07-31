namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    /// <summary>
    /// Factory pattern:
    /// Define an interface to create an object, but will let sub-classes to decide which class will be instantiate.
    /// </summary>
    public abstract class Creator
    {
        public abstract Product FactoryMethod();
    }
}