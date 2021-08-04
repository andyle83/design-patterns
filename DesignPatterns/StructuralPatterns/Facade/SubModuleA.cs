using System;
using System.Reflection;

namespace DesignPatterns.StructuralPatterns.Facade
{
    internal class SubModuleA
    {
        public void OperationA()
        {
            Console.WriteLine($"{this.GetType().Name} + {MethodBase.GetCurrentMethod().Name}");
        }
    }
}