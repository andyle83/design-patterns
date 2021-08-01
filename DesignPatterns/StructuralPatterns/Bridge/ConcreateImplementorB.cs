using System;

namespace DesignPatterns.StructuralPatterns.Bridge
{
    internal class ConcreateImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine($"{this.GetType().Name} operation");
        }
    }
}