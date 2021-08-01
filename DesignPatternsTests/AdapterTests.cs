using DesignPatterns.StructuralPatterns.Adapter;
using Moq;
using NUnit.Framework;

namespace DesignPatternsTests
{
    internal class AdapterTests
    {
        private Mock<Adaptee> _adaptee;
        private Target _target;

        [SetUp]
        public void Setup()
        {
            _adaptee = new Mock<Adaptee>();
            _adaptee.Setup(a => a.SpecificRequest());
            _target = new Adapter(_adaptee.Object);
        }

        [Test]
        public void CallingAdapter_ExpectAdapteeWasCalled()
        {
            // Call to adapter interface
            _target.Request();
            _adaptee.Verify(a => a.SpecificRequest(), Times.Once);
        }
    }
}