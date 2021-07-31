using DesignPatterns.CreationalPatterns.Builder;
using Moq;
using NUnit.Framework;

namespace DesignPatternsTests
{
    public class BuilderTests
    {
        private Builder _builderA;
        private Builder _builderB;
        private Director _director;

        private Mock<Builder> _mockBuilder;

        [SetUp]
        public void Setup()
        {
            _director = new Director();
            _builderA = new ConcreateBuilderA();
            _builderB = new ConcreateBuilderB();

            _mockBuilder = new Mock<Builder>();
            _mockBuilder.Setup(m => m.BuildPartA());
            _mockBuilder.Setup(m => m.BuildPartB());

            // Invoke product construction
            _director.Construct(_builderA);
            _director.Construct(_builderB);
        }

        [Test]
        public void GivingABuilder_ReturnAValidProduct()
        {
            Assert.NotNull(_builderA.GetProduct());
            Assert.NotNull(_builderB.GetProduct());
        }

        [Test]
        public void GivingDifferentBuilders_ReturnDifferentProducts()
        {
            string productResultA = _builderA.GetProduct().Show();
            string productResutlB = _builderB.GetProduct().Show();

            Assert.AreNotEqual(productResultA, productResutlB);
        }

        [Test]
        public void GivingAProduct_ConfirmConstructionWasCalled()
        {
            _director.Construct(_mockBuilder.Object);
            _mockBuilder.Verify(x => x.BuildPartA(), Times.Once);
            _mockBuilder.Verify(x => x.BuildPartB(), Times.Once);
        }
    }
}