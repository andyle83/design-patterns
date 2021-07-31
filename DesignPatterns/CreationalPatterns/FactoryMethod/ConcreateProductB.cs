namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    public class ConcreateProductB : Product
    {
        public override string GetProductInfo()
        {
            return this.GetType().Name;
        }
    }
}