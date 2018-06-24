using System;
using NUnit.Framework;

namespace UnitTestsLibrary
{
    [TestFixture]
    public class NunitExamples
    {
        [Test]
        public void FailExample()
        {
            Assert.Fail();
        }
    }
}
