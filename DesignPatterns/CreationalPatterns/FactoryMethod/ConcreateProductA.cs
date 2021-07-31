using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    public class ConcreateProductA : Product
    {
        public override string GetProductInfo()
        {
            return this.GetType().Name;
        }
    }
}