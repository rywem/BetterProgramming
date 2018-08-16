using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib.Mocking
{
    public class VideoService
    {
        public IFileReader _fileReader { get; set; }
        IVideoRepository _repository { get; set; }
        public string ReadVideoTitle(IFileReader fileReader)
        {
            var str = fileReader.Read("video.txt");
            var video = Newtonsoft.Json.JsonConvert.DeserializeObject<Video>(str);
            if (video == null)
                return "Error parsing the video";

            return video.Title;
        }

        public VideoService(IFileReader reader = null, IVideoRepository repository = null)
        {
            _fileReader = reader ?? new FileReader();
            _repository = repository ?? new VideoRepository();
        }
        public string ReadVideoTitleProp()
        {
            var str = _fileReader.Read("video.txt");
            var video = Newtonsoft.Json.JsonConvert.DeserializeObject<Video>(str);
            if (video == null)
                return "Error parsing the video";

            return video.Title;
        }

        public string GetUnprocessedVideoAsCsv()
        {
            var videoIds = new List<int>();

            var videos = _repository.GetUnprocessedVideos();
            foreach (var v in videos)
            {
                videoIds.Add(v.Id);
            }
            return string.Join(",", videoIds);
            
        }
    }

    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsProcessed { get; set; }
    }

    public class VideoContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
    }
}
