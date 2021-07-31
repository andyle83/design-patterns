namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    public class ConcreateCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreateProductB();
        }
    }
}