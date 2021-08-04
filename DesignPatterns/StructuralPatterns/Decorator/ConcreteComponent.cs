using System;

namespace DesignPatterns.StructuralPatterns.Decorator
{
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine($"{this.GetType().Name}: Operation Called");
        }
    }
}