using System;

namespace DesignPatterns.StructuralPatterns.Decorator
{
    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            // Adding more responsibility
            Console.WriteLine($"{this.GetType().Name}: Operation Called");
        }
    }
}