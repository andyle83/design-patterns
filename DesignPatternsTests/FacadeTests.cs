using DesignPatterns.StructuralPatterns.Facade;
using NUnit.Framework;

namespace DesignPatternsTests
{
    public class FacadeTests
    {
        private Facade facade;

        [SetUp]
        public void Setup()
        {
            facade = new Facade();
        }

        [Test]
        public void CallFaceMethods_ExpectSubModuleInvolved()
        {
            try
            {
                facade.FirstOperation();
                facade.SecondOperation();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }
    }
}