using System;

namespace DesignPatterns.StructuralPatterns.Adapter
{
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called Specific Request");
        }
    }
}