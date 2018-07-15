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
        [Test]
        public void Warnings() 
        {
            Warn.If(2 + 2 != 5);
            //Use lambdas for conditional warnings
            Warn.If(() => 2 + 2, Is.Not.EqualTo(3)); // conditional warnings with lambdas
            //Run the test after 2000 miliseconds
            Warn.If(() => 2 + 2, Is.Not.EqualTo(3).After(2000));
            //warn.unless is the inverse of warn.if
            //"unless some condition holds"
            Warn.Unless(() => 2 + 2, Is.EqualTo(5).After(3000));
            //issue an unconditional warning
            Assert.Warn("This is an unconditional warning");
        }
    }
}
