using BusinessLib.Mocking;
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
        [Test]
        public void ReadVideoTitle_EmptyFileConstructor_ReturnError()
        {
            var service = new VideoService();
            var result = service.ReadVideoTitle(new FakeFileReader());
            Assert.That(result, Does.Contain("error").IgnoreCase);
        }

        [Test]
        public void ReadVideoTitle_EmptyFileProp_ReturnError()
        {
            var service = new VideoService();
            service._fileReader = new FakeFileReader();
            var result = service.ReadVideoTitleProp();
            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
    }
}
