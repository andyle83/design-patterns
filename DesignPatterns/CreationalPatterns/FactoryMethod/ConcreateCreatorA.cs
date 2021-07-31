namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    public class ConcreateCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreateProductA();
        }
    }
}