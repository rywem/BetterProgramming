using NUnit.Framework;
using System;
using BusinessLib.Fundamentals;

namespace BusinessLib.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Fundamentals.Math _math;
        

        
        [SetUp]
        public void SetUp()
        {
            _math = new Fundamentals.Math(); //initialize a new instance with each test
        }
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = _math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }        
    }
}
