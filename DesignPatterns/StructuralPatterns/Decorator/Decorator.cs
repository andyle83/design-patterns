namespace DesignPatterns.StructuralPatterns.Decorator
{
    /// <summary>
    /// Decorator Pattern
    /// Adding more resposibility without using inheritance / subclasses
    /// </summary>
    public abstract class Decorator : Component
    {
        private Component component;

        public Component Component
        {
            set
            {
                component = value;
            }
        }

        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }
}