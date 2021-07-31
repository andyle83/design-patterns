namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    public class ConcreateProductA : Product
    {
        public override string GetProductInfo()
        {
            return this.GetType().Name;
        }
    }
}