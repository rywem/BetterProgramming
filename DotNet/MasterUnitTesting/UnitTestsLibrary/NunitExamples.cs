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
        [Test]
        public void AssertExample()
        {
            try
            {
                Assert.That(2 + 2, Is.EqualTo(4));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
