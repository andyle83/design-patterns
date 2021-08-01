using System;

namespace DesignPatterns.StructuralPatterns.Adapter
{
    /// <summary>
    /// Adapter Pattern:
    /// Convert interface of a class into another interface of client
    /// </summary>
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request");
        }
    }
}