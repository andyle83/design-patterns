using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    public class ConcreateCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreateProductA();
        }
    }
}