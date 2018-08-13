using NUnit.Framework;
using System;
using BusinessLib.Fundamentals;
using System.Linq;

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
        //[Ignore("Just testing ignore")]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = _math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
            //Assert.That(_math, Is.Not.Null);
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
        
        [Test]
        public void GetOddNumbers_LimitIsgreatThanZero_ReturnOddNumbersUpToLimit()
        {
            https://www.udemy.com/unit-testing-csharp/learn/v4/t/lecture/8997692?start=120
            var result = _math.GetOddNumbers(5);

            Assert.That(result, Is.Not.Empty);
            Assert.That(result.Count, Is.EqualTo(3));
            Assert.That(result, Does.Contain(1));
            Assert.That(result, Does.Contain(3));
            Assert.That(result, Does.Contain(5));
            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));
            Assert.That(result, Is.Ordered); //ordered
            Assert.That(result, Is.Unique); //checks that there aren't any duplicates

        }
    }
}
