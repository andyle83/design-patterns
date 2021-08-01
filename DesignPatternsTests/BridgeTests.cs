﻿using DesignPatterns.StructuralPatterns.Bridge;
using Moq;
using NUnit.Framework;

namespace DesignPatternsTests
{
    internal class BridgeTests
    {
        private Abstraction ab;
        private Mock<Implementor> implementor;

        [SetUp]
        public void Setup()
        {
            ab = new RefinedAbstraction();
            implementor = new Mock<Implementor>();

            ab.Implementor = implementor.Object;
            implementor.Setup(m => m.Operation());
        }

        [Test]
        public void CallingBridgeMethod_ExpectedImplementorExecute()
        {
            // Call operation via bridge
            ab.Operation();

            implementor.Verify(m => m.Operation(), Times.Once);
        }
    }
}