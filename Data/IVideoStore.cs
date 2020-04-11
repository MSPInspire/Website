using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1
{
    public interface IVideoStore
    {
        Task<IEnumerable<Video>> GetVideos(string query = "");

        Task<Video> GetVideo(string id);

        Task<Video> UpdateVideo(Video video);
    }
}
