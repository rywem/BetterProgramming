using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLib.Fundamentals;
namespace BusinessLib.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        DemeritPointsCalculator _calculator;
        [SetUp]
        public void SetUp()
        {
            _calculator = new DemeritPointsCalculator();
        }
        [Test]
        public void CalculateDemeritPoints_LessThan0_ThrowsArgumentOutOfRangeException()
        {
            //_calculator.CalculateDemeritPoints(-1);
            Assert.That(() => _calculator.CalculateDemeritPoints(-1), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
        [Test]
        [TestCase(55)]
        [TestCase(65)]
        public void CalculateDemeritPoints_LessThanOrEqualToSpeedLimit_Returns0(int speed)
        {
            var result = _calculator.CalculateDemeritPoints(speed);
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        [TestCase(70, 1)]
        [TestCase(71, 1)]
        [TestCase(75, 2)]
        public void CalculateDemeritPoints_GreatThanSpeedLimit_ReturnsDemerits(int speed, int expectedResult)
        {
            var result = _calculator.CalculateDemeritPoints(speed);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
