using System;
using System.Reflection;

namespace DesignPatterns.StructuralPatterns.Facade
{
    internal class SubModuleB
    {
        public void OperationB()
        {
            Console.WriteLine($"{this.GetType().Name} + {MethodBase.GetCurrentMethod().Name}");
        }
    }
}