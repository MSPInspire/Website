using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class JsonVideosStore
    {
        IDictionary<string, Video> videos;
        InMemorySearchProvider searchProvider;

        public JsonVideosStore()
        {
            var json = File.ReadAllText("videos.json");
            var jsonOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                AllowTrailingCommas = true
            };
            videos = JsonSerializer.Deserialize<Dictionary<string, Video>>(json, jsonOptions);
            searchProvider = new InMemorySearchProvider(videos);
        }

        public Task<IEnumerable<Video>> GetVideos(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return Task.FromResult<IEnumerable<Video>>(videos.Values);
            }
            return Task.FromResult(searchProvider.Search(query));
        }

        public Task<Video> GetVideo(string id)
        {
            videos.TryGetValue(id, out var video);
            return Task.FromResult(video);
        }

        public Task<Video> UpdateVideo(Video video)
        {
            return Task.FromResult(video);
        }
    }
}
