namespace DesignPatterns.StructuralPatterns.Bridge
{
    /// <summary>
    /// Bridge pattern:
    /// Decouple abstraction from its implementation so that we can have various ways of implementation
    /// </summary>
    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }
}