using System;
using System.Reflection;

namespace DesignPatterns.StructuralPatterns.Facade
{
    internal class SubModuleC
    {
        public void OperationC()
        {
            Console.WriteLine($"{this.GetType().Name} + {MethodBase.GetCurrentMethod().Name}");
        }
    }
}