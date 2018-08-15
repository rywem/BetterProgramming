using BusinessLib.Mocking;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib.UnitTests.Mocking
{
    [TestFixture]
    public class VideoServiceTests
    {
        VideoService _service;
        Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void SetUp()
        {
            _service = new VideoService();
            _mockFileReader = new Mock<IFileReader>();
        }
    

        
        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            _mockFileReader.Setup(fr => fr.Read("video.txt")).Returns("");
            var result = _service.ReadVideoTitle(_mockFileReader.Object);
            Assert.That(result, Does.Contain("error").IgnoreCase);
        }

    }
}
