using System;

namespace DesignPatterns.StructuralPatterns.Bridge
{
    public class ConcreateImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine($"{this.GetType().Name} operation");
        }
    }
}