using DesignPatterns.StructuralPatterns.Decorator;
using NUnit.Framework;

namespace DesignPatternsTests
{
    internal class DecoratorTests
    {
        private Decorator decoratorA;
        private Decorator decoratorB;

        [SetUp]
        public void Setup()
        {
            decoratorA = new ConcreteDecoratorA();
            decoratorB = new ConcreteDecoratorB();
        }

        [Test]
        public void CallingConcreteDecorator_ExpectMoreResponsibility()
        {
            try
            {
                decoratorA.Operation();
                decoratorB.Operation();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }
    }
}