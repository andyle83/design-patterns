using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    public abstract class Creator
    {
        public abstract Product FactoryMethod();
    }
}