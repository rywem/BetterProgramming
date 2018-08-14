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
        public string ReadVideoTitle()
        {
            var str = File.ReadAllText("video.txt");
            var video = Newtonsoft.Json.JsonConvert.DeserializeObject<Video>(str);
            if (video == null)
                return "Error parsing the video";

            return video.Title;
        }

        public string GetUnprocessedVideoAsCsv()
        {
            var videoIds = new List<int>();

            using (var context = new VideoContext())
            {
                var videos = (from video in context.Videos
                              where !video.IsProcessed
                              select video).ToList();

                foreach (var v in videos)
                {
                    videoIds.Add(v.Id);
                }
                return string.Join(",", videoIds);
            }
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
