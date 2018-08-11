using NUnit.Framework;
using System;
using BusinessLib.Fundamentals;

namespace BusinessLib.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var math = new BusinessLib.Fundamentals.Math();
            var result = math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
        {
            var math = new BusinessLib.Fundamentals.Math();
            var result = math.Max(2, 1);
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        {
            var math = new BusinessLib.Fundamentals.Math();
            var result = math.Max(2, 3);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        {
            var math = new BusinessLib.Fundamentals.Math();
            var result = math.Max(2, 2);
            Assert.That(result, Is.EqualTo(2));
        }
    }
}
