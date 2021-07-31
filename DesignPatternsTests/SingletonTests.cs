using DesignPatterns.CreationalPatterns.Singleton;
using NUnit.Framework;

namespace DesignPatternsTests
{
    public class SingletonTests
    {
        private Singleton _instance1;
        private Singleton _instance2;

        [SetUp]
        public void Setup()
        {
            _instance1 = Singleton.Instance();
            _instance2 = Singleton.Instance();
        }

        [Test]
        public void GivingTwoInstancesInThreadSafe_BothInstanceMustBeTheSame()
        {
            Assert.That(_instance1, Is.SameAs(_instance2));
        }
    }
}