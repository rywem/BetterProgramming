using BusinessLib.Mocking;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        Mock<IVideoRepository> _mockVideoRepository;
        [SetUp]
        public void SetUp()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockVideoRepository = new Mock<IVideoRepository>();
            _service = new VideoService(_mockFileReader.Object, _mockVideoRepository.Object);
        }
        
        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            _mockFileReader.Setup(fr => fr.Read("video.txt")).Returns("");
            var result = _service.ReadVideoTitle(_mockFileReader.Object);
            Assert.That(result, Does.Contain("error").IgnoreCase);
        }

        [Test]
        public void GetUnprocessedVideosAsCsv_AllVideosAreProcessed_JoinVideos()
        {
            _mockVideoRepository.Setup(vr => vr.GetUnprocessedVideos()).Returns((new List<Video>()).AsEnumerable());
            var result = _service.GetUnprocessedVideoAsCsv();
            Debug.Write(result);
            Assert.That(result, Is.EqualTo(string.Empty));
        }

        [Test]
        public void GetUnprocessedVideosAsCsv_VideosNeedProcessing_JoinVideos()
        {
            _mockVideoRepository.Setup(vr => vr.GetUnprocessedVideos()).Returns((new List<Video>() { new Video() { Id = 1 }, new Video() { Id = 2 } }).AsEnumerable());
            var result = _service.GetUnprocessedVideoAsCsv();
            Debug.Write(result);
            Assert.That(result, Is.EqualTo("1,2"));
        }
    }
}
