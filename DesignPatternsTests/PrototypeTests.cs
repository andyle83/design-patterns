using DesignPatterns.CreationalPatterns.Prototype;
using NUnit.Framework;

namespace DesignPatternsTests
{
    internal class PrototypeTests
    {
        private Prototype prototypeA;
        private Prototype prototypeB;

        [SetUp]
        public void Setup()
        {
            prototypeA = new ConcreatePrototypeA("A");
            prototypeB = new ConcreatePrototypeB("B");
        }

        [Test]
        public void GivingAPrototype_GetNewObjectWithSameState()
        {
            Prototype cloneObject = prototypeA.Clone();

            Assert.NotNull(cloneObject);
            Assert.AreEqual(cloneObject.Id, prototypeA.Id);
        }

        [Test]
        public void GivingDifferentObjectClones_GetDifferentPrototypes()
        {
            Prototype cloneObjectA = prototypeA.Clone();
            Prototype cloneObjectB = prototypeB.Clone();

            Assert.AreNotEqual(cloneObjectA.Id, cloneObjectB.Id);
        }
    }
}