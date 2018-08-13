using BusinessLib.Fundamentals;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(3, "Fizz")]
        [TestCase(9, "Fizz")]
        [TestCase(12, "Fizz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(10, "Buzz")]
        [TestCase(20, "Buzz")]
        [TestCase(22, "22")]
        public void GetOutput_WhenCalled_ReturnsAnswer(int input, string expectedResult)
        {
            var result = FizzBuzz.GetOutput(input);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
