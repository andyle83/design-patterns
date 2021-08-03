using System;

namespace DesignPatterns.StructuralPatterns.Bridge
{
    public class ConcreateImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine($"{this.GetType().Name} operation");
        }
    }
}