using System;

namespace DesignPatterns.StructuralPatterns.Adapter
{
    public class Adaptee
    {
        public virtual void SpecificRequest()
        {
            Console.WriteLine("Called Specific Request");
        }
    }
}