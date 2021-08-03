using DesignPatterns.StructuralPatterns.Composite;
using NUnit.Framework;

namespace DesignPatternsTests
{
    internal class CompositeTests
    {
        private Component component;
        private Component childComponentA, childComponentB;

        [SetUp]
        public void Setup()
        {
            component = new Composite("root");
            childComponentA = new Composite("A");
            childComponentB = new Leaf("B");
        }

        [Test]
        public void CreateCompositeObject_ExpectNoException()
        {
            try
            {
                component.Add(childComponentA);
                component.Add(childComponentB);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }

        [Test]
        public void RemoveComponentElement_ExpectNoException()
        {
            try
            {
                component.Add(childComponentA);
                component.Remove(childComponentA);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }

        [Test]
        public void CallingCompositeOperation_ExpectNoException()
        {
            try
            {
                component.Add(childComponentA);
                childComponentA.Add(childComponentB);
                component.Display(2);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }
    }
}