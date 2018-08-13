using BusinessLib.Fundamentals;
using NUnit.Framework;
using System;

namespace BusinessLib.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            var logger = new ErrorLogger();

            logger.Log("a");
            //is void
            Assert.That(logger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            var logger = new ErrorLogger();
            
            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);
        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            // arrage
            var logger = new ErrorLogger();

            var id = Guid.Empty;
            //subscribe to the event before acting
            logger.ErrorLogged += (sender, args) =>
            {
                id = args; //set id to args
            };
            // act
            logger.Log("a");
            // assert
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}
