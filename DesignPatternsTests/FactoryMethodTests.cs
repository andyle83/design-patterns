using DesignPatterns.CreationalPatterns.FactoryMethod;
using NUnit.Framework;

namespace DesignPatternsTests
{
    internal class FactoryMethodTests
    {
        private Creator[] _creators = new Creator[2];

        [SetUp]
        public void Setup()
        {
            _creators[0] = new ConcreateCreatorA();
            _creators[1] = new ConcreateCreatorB();
        }

        [Test]
        public void GivingDifferentCreators_WillReturnDifferentProductTypes()
        {
            Product productA = _creators[0].FactoryMethod();
            Product productB = _creators[1].FactoryMethod();

            Assert.AreEqual(productA.GetProductInfo(), productA.GetType().Name);
            Assert.AreEqual(productB.GetProductInfo(), productB.GetType().Name);
            Assert.AreNotEqual(productA.GetProductInfo(), productB.GetProductInfo());
        }

        [Test]
        public void GivingSameCreator_WillReturnSameProductType()
        {
            Product product1 = _creators[0].FactoryMethod();
            Product product2 = _creators[0].FactoryMethod();

            Assert.AreEqual(product1.GetProductInfo(), product2.GetProductInfo());
        }
    }
}